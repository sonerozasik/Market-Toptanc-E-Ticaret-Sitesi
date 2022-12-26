<template>
    <div id="shoppingCart" class="card position-absolute top-50 start-50 translate-middle p-4">
      <h1 >Alışveriş Sepeti</h1>
        <BIconX class="fs-2 position-absolute top-0 end-0" @click="handleCart()"/>
        <table class="table table-striped" >
          <thead>
            <tr >
              <th scope="col">Ürün Kodu</th>
              <th scope="col">Ürün Adı</th>
              <th scope="col">Fiyatı</th>
              <th scope="col">Miktar</th>
              <th scope="col">Toplam Fiyat</th>
              <th scope="col"></th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="item in cartItems">
              <th scope="row">{{item.id}}</th>
              <td>{{ item.product.productName }}</td>
              <td>{{ item.product.price }}</td>
              <td>{{ item.quantity }}</td>
              <td>{{ item.totalPrice }}</td>
              <div class="d-flex justify-content-end">
                  <button class="btn bg-danger text-white" @click="deleteItem(item.id)">Sepetten Sil!</button>
              </div>
            </tr>
          </tbody>
        </table>
        <!--
        <span>Ürün Adı - Ürün Miktarı - Ürün Fiyatı - Toplam Fiyat</span>
      <ul  class="list-group">
        <li v-for="item in cartItems" :key="item.id" class="list-group-item">
            {{ item.product.productName }} - {{ item.quantity }} - {{ item.product.price }} - {{item.totalPrice}} <button>asd</button>
        </li>
      </ul>-->
      <h4 class="text-center">Toplam Tutar: {{ total }} TL</h4>
      <button class="btn bg-primary col-6 mx-auto text-white" @click="completeOrder()">Siparişi Tamamla</button>
    </div>
  </template>
  
  <script>
import { BIconX } from 'bootstrap-icons-vue';

import axios from 'axios';

  export default {
    name: 'ShoppingCart',
    data() {
      return {
        cartItems: [
        ],
        total:0
      };
    },
    props:{
      userId : Number
    },
    methods:{
        handleCart(){
            this.$emit("handleCart")
        },
        deleteItem(itemId){
          axios.delete("https://localhost:7185/api/CartItems/"+itemId)
          .then(response=>{
            console.log(response)
            if(response.status==200){
              this.renderContent();
            }
          })
        },
        renderContent(){
          axios.get("https://localhost:7185/api/GroceryStoreUsers/getByUserId/"+this.userId)
            .then(response=>{
              console.log(response)
              this.user = response.data;
            })
            .then(()=>{
              axios.get("https://localhost:7185/api/ShoppingCarts/"+this.user.shoppingCartId)
              .then(response => {
                console.log(response)
                this.cartItems = response.data.cartItems;
                this.total = response.data.totalPrice;
              })
            })
        },
        completeOrder(){
          console.log(this.cartItems[0].product.wholeSalerUserId)
          axios.post("https://localhost:7185/api/Orders",
          {
            DeliveryStatus : "waiting",
            GroceryStoreUserId : this.user.id,
            WholeSalerUserId : this.cartItems[0].product.wholeSalerUserId,
            TotalPrice:0
          })
          .then(response=>{
            console.log(response)
            this.cartItems.forEach(element => {
              console.log("aaaaaaaaa")
              console.log(response.data.id)
              axios.post("https://localhost:7185/api/OrderItems",
              {
                ProductId : element.productId,
                Quantity : element.quantity,
                TotalPrice : element.totalPrice,
                OrderId : response.data.id
              })
              .then(response2=>{
                console.log(response2)
                if(response2.status) this.total = 0;
              })
              .catch(e=>console.log(e))
            });
           
          })
          .catch(e=>console.log(e))
        }
    },
    components:{
        BIconX
    },
    computed: {
        //total() {
         //   return this.cartItems.reduce((acc, item) => acc + item.quantity * item.product.price, 0);
          //  }
    },
    mounted(){
      this.renderContent()
    }
  }
  </script>

  <style>

    #shoppingCart{
        width: 700px;
    }
    
</style>