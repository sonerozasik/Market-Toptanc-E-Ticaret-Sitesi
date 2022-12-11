<template>
    <div id="shoppingCart" class="card position-absolute top-50 start-50 translate-middle">
      <h1 >Shopping Cart</h1>
        <BIconX class="fs-2 position-absolute top-0 end-0" @click="handleCart()"/>
      <ul  class="list-group">
        <li v-for="item in cartItems" :key="item.id" class="list-group-item">
            {{ item.name }} - {{ item.quantity }} - {{ item.price }}
        </li>
        <p>Toplam Tutar: {{ total }} TL</p>
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
            { name: "Apple", quantity: 5, price: 0.99 },
            { name: "Orange", quantity: 2, price: 0.49 },
            { name: "Banana", quantity: 3, price: 0.29 }
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