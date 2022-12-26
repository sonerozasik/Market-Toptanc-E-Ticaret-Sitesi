<template>
    <div id="orderDetails" class="card position-absolute top-50 start-50 translate-middle p-4">
      <h1 >Sipariş Detayları</h1>
        <BIconX class="fs-2 position-absolute top-0 end-0" @click="handleDetails()"/>
        <table class="table table-striped" >
          <thead>
            <tr >
              <th scope="col">Ürün Kodu</th>
              <th scope="col">Ürün Adı</th>
              <th scope="col">Fiyatı</th>
              <th scope="col">Miktar</th>
              <th scope="col">Toplam Fiyat</th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="item in orderItems">
              <th scope="row">{{item.id}}</th>
              <td>{{ item.product.productName }}</td>
              <td>{{ item.product.price }}</td>
              <td>{{ item.quantity }}</td>
              <td>{{ item.totalPrice }}</td>
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
    </div>
  </template>
  
  <script>
import { BIconX } from 'bootstrap-icons-vue';

import axios from 'axios';

  export default {
    name: 'OrderDetails',
    data() {
      return {

      };
    },
    props:{
      userId : Number,
      orderItems : Array,
      total : Number, 
    },
    methods:{
        handleDetails(){
            this.$emit("handleDetails")
        }
    },
    components:{
        BIconX
    }
  }
  </script>

  <style>

    #orderDetails{
        width: 700px;
    }
    
</style>