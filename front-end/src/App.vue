<template>
  <div class="container">
    <Navbar :isAuthenticated="isAuthenticated"
      :userRole="userRole"
      v-on:handleCart="isCartOpen = isCartOpen ? false : true"
    />
    <RouterView 
      v-on:loginResponse="loginResponse($event)"
      v-on:signupResponse="signupResponse($event)"
      v-on:addProductResponse="addProductResponse($event)"
      v-on:handleError="errorMessage($event)"
      :userId="userId"
      :userRole="userRole"

    />
    <ShoppingCart v-if="isCartOpen" 
      v-on:handleCart="isCartOpen = isCartOpen ? false : true" 
      :userId="userId"

    />
  </div>

</template>

<script>
import Navbar from './components/Navbar.vue'
import Swal from 'sweetalert2'
import ShoppingCart from './components/ShoppingCart.vue'

export default {
  name: 'App',
  data(){
    return{
      isAuthenticated:false,
      isCartOpen:false,
      userRole : 0,
      userId:0
    }
  },
  components: {
    Navbar,
    ShoppingCart
  },
  methods:{
    loginResponse(response) {
        if (response.succes == true) {
            this.isAuthenticated = true;
            this.username = response.username;
            this.succesMessage(response.message);
            this.isAuthenticated=true;
            this.userRole = response.userRole;
            this.userId= response.userId;
            if(this.userRole == 1) this.$router.push("/supplier-list");
            else if(this.userRole == 2) this.$router.push("/order-list");
        }
        else {
            this.errorMessage(response.message);
        }
    },
    signupResponse(response) {
        if (response.succes == true) {
            this.$router.push("/login");
            this.succesMessage(response.message);
        }
        else {
            this.errorMessage(response.message);
        }
    },
    addProductResponse(response) {
        if (response.succes == true) {
            this.succesMessage(response.message);
        }
        else {
            this.errorMessage(response.message);
        }
    },
    errorMessage(messageText) {
      Swal.fire({
          icon: "error",
          title: "Oops...",
          text: messageText,
      });
    },
    succesMessage(messageText) {
      Swal.fire({
          position: "top",
          icon: "success",
          title: messageText,
          showConfirmButton: false,
          timer: 1500
      });
    }
  }
}
</script>


<style>
  svg:hover{
    cursor: pointer;
  }
</style>