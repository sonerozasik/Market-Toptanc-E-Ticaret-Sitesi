CREATE OR REPLACE FUNCTION public.addshoppingcart_function()
    RETURNS trigger
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE NOT LEAKPROOF
AS $BODY$
	DECLARE ScId integer;
BEGIN
	INSERT INTO "ShoppingCarts" ("TotalPrice") VALUES (0) RETURNING "Id" INTO ScId;
	UPDATE "GroceryStoreUsers" SET "ShoppingCartId" = ScId WHERE "Id" = NEW."Id";
	RETURN NULL;
END;
$BODY$;

CREATE OR REPLACE TRIGGER addshoppingcart
    AFTER INSERT OR UPDATE --update not tested
    ON public."GroceryStoreUsers"
    FOR EACH ROW
    EXECUTE FUNCTION public.addshoppingcart_function();

-----------------------------------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION CalculateTotalPriceFunction()
    RETURNS trigger
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE NOT LEAKPROOF
AS $BODY$
	DECLARE Prc double precision;
BEGIN
	SELECT "Price" FROM "Products" WHERE "Id" = NEW."ProductId" INTO Prc;
	UPDATE "CartItems" SET "TotalPrice" = "Quantity" * Prc WHERE NEW."Id" = "Id";
	
	UPDATE "ShoppingCarts" SET "TotalPrice" = 
	(SELECT SUM(CI."TotalPrice") FROM "CartItems" AS CI
	 INNER JOIN "ShoppingCarts" AS SC ON SC."Id" = CI."ShoppingCartId"
	 WHERE SC."Id" = NEW."ShoppingCartId") 
	WHERE NEW."ShoppingCartId" = "Id";
	
	RETURN NULL;
END;
$BODY$;

CREATE OR REPLACE TRIGGER CalculateTotalPrice
    AFTER INSERT OR UPDATE
    ON public."CartItems"
    FOR EACH ROW
    EXECUTE FUNCTION CalculateTotalPriceFunction();


-- bunun aynısını OrderItems için de ekle

-----------------------------------------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION CreateOrderFunction()
    RETURNS trigger
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE NOT LEAKPROOF
AS $BODY$
BEGIN
	DELETE FROM "CartItems" WHERE "Id" = (SELECT CI."Id" FROM "CartItems" AS CI
INNER JOIN "GroceryStoreUsers" AS GSU ON CI."ShoppingCartId" = GSU."ShoppingCartId"
INNER JOIN "Orders" AS O ON O."GroceryStoreUserId" = GSU."Id"
--INNER JOIN "OrderItems" As OI ON O."Id" = OI."OrderId"
WHERE NEW."ProductId" = CI."ProductId" AND NEW."Quantity" = CI."Quantity" 
AND O."Id" = NEW."OrderId" );
RETURN NULL;
END;
$BODY$;

CREATE OR REPLACE TRIGGER CreateOrder
    AFTER INSERT
    ON public."OrderItems"
    FOR EACH ROW
    EXECUTE FUNCTION CreateOrderFunction();

------------------------------------------------------------------------------------
CREATE OR REPLACE FUNCTION CalculateTotalPriceFunction()
    RETURNS trigger
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE NOT LEAKPROOF
AS $BODY$
	DECLARE Prc double precision;
BEGIN
	SELECT "Price" FROM "Products" WHERE "Id" = NEW."ProductId" INTO Prc;
	UPDATE "CartItems" SET "TotalPrice" = "Quantity" * Prc WHERE NEW."Id" = "Id";
	
	IF (SELECT COUNT("Id") FROM "CartItems" WHERE "ShoppingCartId"=NEW."ShoppingCartId") = 0 THEN
		UPDATE "ShoppingCarts" SET "TotalPrice" = 0;
		
	ELSE
	
		UPDATE "ShoppingCarts" SET "TotalPrice" = 
		(SELECT SUM(CI."TotalPrice") FROM "CartItems" AS CI
		 INNER JOIN "ShoppingCarts" AS SC ON SC."Id" = CI."ShoppingCartId"
		 WHERE SC."Id" = NEW."ShoppingCartId") 
		WHERE NEW."ShoppingCartId" = "Id";
	
	END IF;
	RETURN NULL;
END;
$BODY$;