<template>
    <div class="card col-6 p-5 m-auto mt-5">
        <form id="signUpForm">
          <div class="form-group">
            <h1 class="text-center">Ürün Ekle</h1>
            <div class="d-flex justify-content-center">
            </div>
              <div class="col">
                <label for="exampleInputEmail1">Ürün Adı</label>
                <input type="text" class="form-control" id="productName" v-model="productName">
              </div>
              <div class="col">
                <label for="exampleInputEmail1">Fiyat</label>
                <input type="number" class="form-control" min="0" id="price" v-model="price">
              </div>
              <div class="col">
                <label for="exampleInputEmail1">Kategori</label>
                <select class="form-select" v-model="category">
                    <option selected disabled>Kategori seçiniz</option>
                    <option v-for="category in categories" v-bind:value="category.id">{{category.name}}</option>
                  </select>
              </div>
              <div class="col">
                <label for="exampleInputEmail1">Stok Miktarı</label>
              <input type="number" class="form-control" id="stockAmount" v-model="stockAmount">
              </div>     
              <div class="col">
                <label for="exampleInputEmail1">Stok Tipi</label>
                <input type="text" class="form-control" id="stockType" v-model="stockType">
              </div>
              <div class="col">
                <label for="exampleInputEmail1">Stok Açıklaması</label>
                <input type="text" class="form-control" id="stockDescription" v-model="stockDescription">
              </div>
         </div>
          <br>
          <div class="d-flex justify-content-center">
            <button type="button" class="btn btn-primary col-6" @click="addProduct()" >Ürün Ekle</button>
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
      categories : [],
      productName:"",
      price:0,
      category:0,
      stockAmount:0,
      stockType:"",
      stockDescription:"",
      stockId:0,
      wholeSalerUserId:0
    }
  },
  props:{
    userId : Number,
  },
  methods: {
   addProduct(){

    axios.post("https://localhost:7185/api/Stocks",
        {
            Quantity : this.stockAmount,
            StockType : this.stockType,
            Description : this.stockDescription,
        })
        .then(response=>{
            console.log(response)
            if(response.status==200){    
                axios.post("https://localhost:7185/api/Products",
                {
                    ProductName : this.productName,
                    Price : this.price,
                    Thumbnail : "empty",
                    CategoryId : this.category,
                    WholeSalerUserId : this.wholeSalerUserId,
                    StockId : response.data.id
                })
                .then(response2=>{
                    console.log(response2)
                    if(response2.status==200)
                    this.$emit('addProductResponse',{message:"Ürün Başarıyla Eklendi!",succes:true});
                    else
                    this.$emit('addProductResponse',{message:"Ürün Ekleme Başarısız!",succes:false});

                })
                }
        })
        
   }
  },
  created(){
    axios.get("https://localhost:7185/api/Categories")
    .then(response=>{
        console.log(response)
        this.categories = response.data
    })
    axios.get("https://localhost:7185/api/WholeSalerUsers/getId/"+this.userId)
    .then(response=>{
        console.log(response)
        this.wholeSalerUserId = response.data;
    })
  }
}

</script>