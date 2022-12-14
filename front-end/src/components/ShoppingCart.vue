<template>
    <div id="shoppingCart" class="card position-absolute top-50 start-50 translate-middle p-4">
      <h1 >Alışveriş Sepeti</h1>
        <BIconX class="fs-2 position-absolute top-0 end-0" @click="handleCart()"/>
        <span>Ürün Adı - Ürün Miktarı - Ürün Fiyatı - Toplam Fiyat</span>
      <ul  class="list-group">
        <li v-for="item in cartItems" :key="item.id" class="list-group-item">
            {{ item.name }} - {{ item.quantity }} - {{ item.price }} - {{item.price*item.quantity}}
        </li>
        <h4 class="text-center">Toplam Tutar: {{ total }} TL</h4>
      </ul>
      <button class="btn bg-primary col-6 mx-auto text-white">Siparişi Tamamla</button>
    </div>
  </template>
  
  <script>
import { BIconX } from 'bootstrap-icons-vue';


  export default {
    name: 'ShoppingCart',
    data() {
      return {
        cartItems: [
            { name: "Temizlik Bezi", quantity: 5, price: 299.00 },
            { name: "Ülker Çikolata", quantity: 2, price: 100.00 }
        ],
      };
    },
    methods:{
        handleCart(){
            this.$emit("handleCart")
        }
    },
    components:{
        BIconX
    },
    computed: {
        total() {
            return this.cartItems.reduce((acc, item) => acc + item.quantity * item.price, 0);
            }
        }
    }
  </script>

  <style>

    #shoppingCart{
        width: 500px;
    }
    
</style>