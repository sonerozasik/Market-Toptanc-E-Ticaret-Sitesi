<template>
    <nav class="navbar navbar-expand-lg navbar-light bg-light">
        <div class="collapse navbar-collapse" id="navbarNavDropdown">
          <ul class="navbar-nav ml-auto">
            <li class="nav-item active" v-if="!isAuthenticated">
              <router-link class="nav-link" to="/login" >Giriş Yap</router-link>
            </li>
            <li class="nav-item" v-if="!isAuthenticated">
              <router-link class="nav-link" to="/signup" >Üye Ol</router-link>
            </li>
            <li class="nav-item" v-if="isAuthenticated && userRole==1">
              <router-link class="nav-link" to="/product-list" >Mağaza</router-link>
            </li>
            <li class="nav-item" v-if="isAuthenticated && userRole==1">
              <router-link class="nav-link" to="/supplier-list" >Toptancılar</router-link>
            </li>
            <li class="nav-item" v-if="isAuthenticated">
              <router-link class="nav-link" to="/order-list">Siparişlerim</router-link>
            </li>
            <li class="nav-item" v-if="isAuthenticated && userRole==2">
              <router-link class="nav-link" to="/self-product-list" >Ürünlerim</router-link>
            </li>
            <li class="nav-item" v-if="isAuthenticated && userRole==2">
              <router-link class="nav-link" to="/add-product" >Ürün Ekle</router-link>
            </li>
            <li class="nav-item" v-if="isAuthenticated && userRole==2">
              <router-link class="nav-link" to="/add-multiple-products" >Ürün Ekle(Excel)</router-link>
            </li>
          </ul>
          <div class="navbar-nav ms-auto pe-5" v-if="isAuthenticated && userRole==1">
            <BIconCart4 @click="cartHandler()" />
          </div>
        </div>
      </nav>
</template>

<script>
import { BIconCart4} from 'bootstrap-icons-vue';
import axios from 'axios';
export default{
  data(){
    return{
      user:{}
    }
  },
  props:{
    isAuthenticated:Boolean,
    isCartOpen:Boolean,
    userRole:Number,
    userId: Number
  },
  components:{
    BIconCart4,
  },
  methods:{
    cartHandler(){
      console.log(this.userRole)
      this.$emit("handleCart"); 
    }
  }

}

</script>

<style>

</style>