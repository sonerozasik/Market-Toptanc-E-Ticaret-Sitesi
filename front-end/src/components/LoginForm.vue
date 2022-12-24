<template>
    <div class="card col-6 p-5 m-auto mt-5">
        <form>
          <div class="form-group">
            <h1 class="text-center">Giriş Yap</h1>
            <label for="exampleInputEmail1">Kullanıcı Adı</label>
            <input type="text" class="form-control" v-model="username">
          </div>
          <br>
          <div class="form-group">
            <label for="exampleInputPassword1">Şifre</label>
            <input type="password" class="form-control" v-model="password">
          </div>
          <br>
          <!--<div class="d-flex justify-content-center">
            <div class="form-check form-check-inline">
                <input class="form-check-input" type="radio" name="inlineRadioOptions" id="inlineRadio1" value="option1" checked>
                <label class="form-check-label" for="inlineRadio1">Market</label>
              </div>
              <div class="form-check form-check-inline">
                <input class="form-check-input" type="radio" name="inlineRadioOptions" id="inlineRadio2" value="option2">
                <label class="form-check-label" for="inlineRadio2">Toptancı</label>
              </div>
          </div>-->
          <br>
          <div class="d-flex justify-content-center">
            <button type="button" class="btn btn-primary col-6" @click="login()">Giriş</button>
          </div>
        </form>
      </div>
</template>

<script>
import axios from 'axios';

export default {
  name: 'LoginForm',
    data() {
        return {
        username:"",
        password:""
        }
  },
  methods: {
   login(){
        axios.get("https://localhost:7185/api/Users/login/"+this.username+"/"+this.password)
        .then(response=>{
          console.log(response)
          if(response.status==200 && response.data==true){
            this.$emit('loginResponse',{message:"Giriş Başarılı!",succes:true});
          }
          else 
          this.$emit('loginResponse',{message:"Giriş Başarısız!",succes:false});
        })
        .catch(e=>{
          console.log(e)
          this.$emit('loginResponse',{message:"Giriş Başarısız!",succes:false});
        })
   }
  }
}

</script>