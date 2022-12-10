<template>
    <div class="card col-6 p-5 m-auto mt-5">
        <form>
          <div class="form-group">
            <h1 class="text-center">Giriş Yap</h1>
            <label for="exampleInputEmail1">Email adresi</label>
            <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp">
          </div>
          <br>
          <div class="form-group">
            <label for="exampleInputPassword1">Şifre</label>
            <input type="password" class="form-control" id="exampleInputPassword1">
          </div>
          <br>
          <div class="d-flex justify-content-center">
            <div class="form-check form-check-inline">
                <input class="form-check-input" type="radio" name="inlineRadioOptions" id="inlineRadio1" value="option1" checked>
                <label class="form-check-label" for="inlineRadio1">Market</label>
              </div>
              <div class="form-check form-check-inline">
                <input class="form-check-input" type="radio" name="inlineRadioOptions" id="inlineRadio2" value="option2">
                <label class="form-check-label" for="inlineRadio2">Toptancı</label>
              </div>
          </div>
          <br>
          <div class="d-flex justify-content-center">
            <button class="btn btn-primary col-6" @click="login()">Giriş</button>
          </div>
        </form>
      </div>
</template>

<script>
export default {
  name: 'LoginForm',
    data() {
        return {
        // Burada giriş formunuza ait verileri tanımlayacaksınız
        }
  },
  methods: {
   login(){
        this.$emit('loginResponse',{message:"Successful Login!",succes:true});
   }
  }
}

</script>