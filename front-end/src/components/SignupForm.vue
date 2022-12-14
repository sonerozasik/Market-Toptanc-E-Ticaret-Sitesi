<template>
    <div class="card col-6 p-5 m-auto mt-5">
        <form>
          <div class="form-group">
            <h1 class="text-center">Üye Ol</h1>
            <div class="d-flex justify-content-center">
              <div class="form-check form-check-inline">
                  <input class="form-check-input" type="radio" name="inlineRadioOptions" id="inlineRadio1" value="option1">
                  <label class="form-check-label" for="inlineRadio1">Market</label>
                </div>
                <div class="form-check form-check-inline">
                  <input class="form-check-input" type="radio" name="inlineRadioOptions" id="inlineRadio2" value="option2">
                  <label class="form-check-label" for="inlineRadio2">Toptancı</label>
                </div>
            </div>
            <label for="exampleInputEmail1">Email adresi</label>
            <input type="email" class="form-control" id="email" aria-describedby="emailHelp">
            <br>
            <label for="exampleInputEmail1">Ad Soyad</label>
            <input type="text" class="form-control" id="nameSurname" aria-describedby="emailHelp">
            <br>
            <label for="exampleInputEmail1">İşletme Adı</label>
            <input type="text" class="form-control" id="storeName" aria-describedby="emailHelp">
            <br>
            <label for="exampleInputEmail1">İşletme Adresi</label>
            <input type="text" class="form-control" id="storeAddress" aria-describedby="emailHelp">
            <br>
            <label for="exampleInputPassword1">Şifre</label>
            <input type="password" class="form-control" id="password">
            <br>
            <label for="exampleInputPassword1">Şifreyi Onayla</label>
            <input type="password" class="form-control" id="confirmPassword">
          </div>
          <br>
          <div class="d-flex justify-content-center">
            <button type="submit" class="btn btn-primary col-6" @click="register()" >Üye Ol</button>
          </div>
        </form>
      </div>
</template>

<script>
export default {
  name: 'SignupForm',
  data() {
    return {

    }
  },
  methods: {
    register(){
      this.$emit('signupResponse',{message:"Kayıt Başarılı!",succes:true});
        
    }
  }
}

</script>