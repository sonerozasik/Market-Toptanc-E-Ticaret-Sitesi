<template>
    <div class="card col-6 p-5 m-auto mt-5">
        <form id="signUpForm">
          <div class="form-group">
            <h1 class="text-center">Üye Ol</h1>
            <div class="d-flex justify-content-center">
              <div class="form-check form-check-inline">
                  <input class="form-check-input" type="radio" name="inlineRadioOptions" id="marketRadio" value="GroceryStoreUsers" v-model="userType">
                  <label class="form-check-label" for="inlineRadio1">Market</label>
                </div>
                <div class="form-check form-check-inline">
                  <input class="form-check-input" type="radio" name="inlineRadioOptions" id="toptancıRadio" value="WholeSalerUsers" v-model="userType">
                  <label class="form-check-label" for="inlineRadio2">Toptancı</label>
                </div>
            </div>
            <div class="row">
              <div class="col">
                <label for="email">E-mail</label>
                <input type="email" class="form-control" id="email" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$" v-model="email">
              </div>
              <div class="col">
                <label for="username">Kullanıcı Adı</label>
                <input type="text" class="form-control" id="username" v-model="username">
              </div>
            </div>
            <div class="row">
              <div class="col">
                <label for="exampleInputEmail1">Ad</label>
              <input type="text" class="form-control" id="name" v-model="name">
              </div>
              <div class="col">
                <label for="exampleInputEmail1">Soyad</label>
              <input type="text" class="form-control" id="surname" v-model="surname">
              </div>     
              <br>
            </div>
            <div class="row">
              <div class="col">
                <label for="exampleInputEmail1">İşletme Adı</label>
                <input type="text" class="form-control" id="storeName" v-model="storeName">
              </div>
              <div class="col">
                <label for="exampleInputEmail1">Telefon Numarası</label>
                <input type="text" class="form-control" id="storePhone" v-model="storePhone">
              </div>
            </div>
            <div class="row">
              <div class="col">
                <label for="exampleInputEmail1">Adres / İl</label>
                <input type="text" class="form-control" id="storeCity" v-model="storeCity">
              </div>
              <div class="col">
                <label for="exampleInputEmail1">Adres / İlçe</label>
                <input type="text" class="form-control" id="storeDistrict" v-model="storeDistrict">
              </div>
            </div>
            <div class="row">
              <div class="col">
                <label for="exampleInputEmail1">Adres / Mahalle, Sokak, Numara</label>
                <input type="text" class="form-control" id="storeStreet" v-model="storeStreet">
              </div>
              <div class="col">
                <label for="exampleInputEmail1">Adres / Posta Kodu</label>
                <input type="text" class="form-control" id="storeZip" v-model="storeZip">
              </div>
            </div>
            <div class="row">
              <div class="col">
                <label for="exampleInputPassword1">Şifre</label>
                <input type="password" class="form-control" id="password" v-model="password">
              </div>
              <div class="col">
                <label for="exampleInputPassword1">Şifreyi Onayla</label>
                <input type="password" class="form-control" id="confirmPassword" v-model="confirmPassword">
              </div>
            </div>
            <div class="row">
              <div class="col">
                <label for="exampleInputPassword1">Açıklama</label>
                <input type="text" class="form-control" id="description" v-model="description">
              </div>
            </div>
         </div>
          <br>
          <div class="d-flex justify-content-center">
            <button type="button" class="btn btn-primary col-6" @click="register()" >Üye Ol</button>
          </div>
        </form>
      </div>
</template>

<script>
import axios from "axios"
export default {
  name: 'SignupForm',
  data() {
    return {
      username: "",
      email : "",
      name: "",
      surname: "",
      storeName:"",
      storeCity:"",
      storePhone:"",
      storeStreet:"",
      storeZip:"",
      storeDistrict: "",
      password:"",
      confirmPassword:"",
      userType:"GroceryStoreUsers"
    }
  },
  methods: {
    register(){
      var RoleId = 2;
      if(this.userType=="GroceryStoreUsers") RoleId = 1
      if(this.confirmPassword==this.password){
        axios
        .post("https://localhost:7185/api/Users",
        { FirstName:this.name,
          LastName:this.surname,
          Username:this.username,
          Email:this.email,
          PasswordHash: this.password,
          PhoneNumber: this.storePhone,
          Picture: "empty",
          Description: this.description,
          City: this.storeCity,
          District: this.storeDistrict,
          Street: this.storeStreet,
          ZipCode: this.storeZip,
          RoleId : RoleId,
        })
        .then(response=>{
          console.log(response)
          if(response.status==200){
            axios
            .post("https://localhost:7185/api/"+this.userType,
            {
              UserId: response.data.id,
              StoreName: this.storeName,
              CompanyName: this.storeName
            })
            .then(response2=>{
              console.log(response2)
              this.$emit('signupResponse',{message:"Kayıt Başarılı!",succes:true});
            })
            .catch(e=>{
              console.log(e)
              this.$emit('signupResponse',{message:"Kayıt Başarısız!",succes:false})
            });

          }
        })
        .catch(e=>{
          console.log(e)
          this.$emit('signupResponse',{message:"Kayıt Başarısız!",succes:false});
        })
      }
      else
        this.$emit('signupResponse',{message:"Kayıt Başarısız!",succes:false});
        
    }
  }
}

</script>