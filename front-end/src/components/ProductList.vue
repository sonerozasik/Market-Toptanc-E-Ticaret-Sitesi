<template>
    <table class="table" >
        <thead>
          <tr >
            <th scope="col">Ürün Adı</th>
            <th scope="col">Minimum Fiyat</th>
            <th scope="col">Maksimum Fiyat</th>
            <th scope="col">Ürün Toptancısı</th>
            <th scope="col">Kategori</th>  

          </tr>
        </thead>
        <tbody>
          <tr>
            <td><input type="text" style="width:200px" placeholder="Ürün Adı"> </td>
            <td><input type="number" style="width:100px" @keypress="control($event)" placeholder="0" min="0"> </td>
            <td><input type="number" style="width:100px" @keypress="control($event)" placeholder="0" min="0"> </td>
            <td><input type="text" style="width:200px" placeholder="Toptancı"> </td>
            <td><select name="category" id="category" >
              <option value="Hepsi">Hepsi</option>
              <option v-for="category in categories" value="{{category.name}}">{{category.name}}</option>
            </select> </td>
            <div class="d-flex justify-content-end">
                <button class="btn bg-primary text-white">Filtrele</button>
            </div>
          </tr>
        </tbody>
      </table>

    <table class="table table-striped" >
      <thead>
        <tr >
          <th scope="col">Ürün Kodu</th>
          <th scope="col">Ürün Adı</th>
          <th scope="col">Fiyatı</th>
          <th scope="col">Birim Fiyatı</th>
          <th scope="col">Toptancı</th>
          <th scope="col">Stok Türü</th>
          <th scope="col" >Miktar</th>
          <th scope="col"></th>

        </tr>
      </thead>
      <tbody>
        <tr v-for="product in products">
          <th scope="row">{{ product.id }}</th>
          <td>{{ product.name }}</td>
          <td>{{ product.price }}</td>
          <td>{{ (product.price/product.stockamount).toFixed(2) }}</td>
          <td>{{ product.supplier }}</td>
          <td>{{ product.stockamount }} {{ product.stocktype }}</td>
          <td><input type="number" style="width:100px" @keypress="control($event)" placeholder="0" min="0"> </td>
          <div class="d-flex justify-content-end">
              <button class="btn bg-primary text-white">Sepete Ekle!</button>
          </div>
        </tr>
      </tbody>
    </table>
</template>


<script>
export default {
  name: "SupplierList",
  data() {
    return {
      products : [
        {
            id:1,
            name:"Eti Çikolata",
            price: 50,
            supplier: "Eti",
            stocktype: "Adet",
            stockamount:12
        },
        {
            id:2,
            name:"Ülker Çikolata",
            price: 100.00,
            supplier: "Ülker",
            stocktype: "Adet",
            stockamount:24

        },
        {
            id:3,
            name:"ACE Çamaşır Suyu",
            price: 110.99,
            supplier: "ACE",
            stocktype: "Adet",
            stockamount:6

        },
        {
            id:4,
            name:"Temizlik Bezi",
            price: 299.00,
            supplier: "Acord",
            stocktype: "Adet",
            stockamount:30
        },

      ],
      categories : [
        {
          name: "Gıda"
        },
        {
          name: "Temizlik"
        }
      ]
    }
    
  },
  created() {
    // Burada toptancıların listesini yükleyebilirsiniz
    // Örneğin, bir HTTP isteği ile bir API'dan verileri alabilirsiniz
  },
  methods:{
    control(evt){
        if (evt.which != 8 && evt.which != 0 && evt.which < 48 || evt.which > 57)
        {
            evt.preventDefault();
        }
    }
}

}


</script>

<style>
    

</style>