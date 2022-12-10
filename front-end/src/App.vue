<template>
  <div class="container">
    <Navbar/>
    <RouterView 
    v-on:loginResponse="loginResponse($event)"
    />
  </div>

</template>

<script>
import Navbar from './components/Navbar.vue'
import Swal from 'sweetalert2'

export default {
  name: 'App',
  components: {
    Navbar
  },
  methods:{
    loginResponse(response) {
        if (response.succes == true) {
            this.isAuthenticated = true;
            this.username = response.username;
            this.succesMessage(response.message);
            this.$router.push("/supplier-list");
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
