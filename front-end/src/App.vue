<template>
  <div class="container">
    <Navbar :isAuthenticated="isAuthenticated"
      v-on:handleCart="isCartOpen = isCartOpen ? false : true"
    />
    <RouterView 
      v-on:loginResponse="loginResponse($event)"
      v-on:signupResponse="signupResponse($event)"

    />
    <ShoppingCart v-if="isCartOpen" 
      v-on:handleCart="isCartOpen = isCartOpen ? false : true" 
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
      isCartOpen:false
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
            this.$router.push("/supplier-list");
            this.isAuthenticated=true;
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