<template>
    <div class="card col-6 p-5 m-auto mt-5">
        <form id="addProductsWithExcel">
            <h1>Excel ile Ürün Ekle</h1>
            <div class="row">
                <input type="file" name="excelFile" id=""
                @change="addFile"
                placeholder="Upload file">
            </div>
            <br>
            <button type="button" class="btn btn-primary col-6" @click="addProducts()" >Ürün Ekle</button>
        </form>
      </div>
</template>

<script>
import axios from "axios"
import readXlsxFile from 'read-excel-file'

export default {
  name: 'AddProductWithExcel',
  data() {
    return {
        dataArray: [],
        wholeSalerUserId : 0
    }
  },
  props:{
    userId : Number,
  },
  methods: {
   addProducts(){
        axios.post("https://localhost:7185/api/Products/listOfProducts",this.dataArray)
        .then(response=>{
            console.log(response)

        })
        .catch(e=>console.log(e))
   },
   addFile(event){
        let xlsxfile = event.target.files ? event.target.files[0] : null;
        readXlsxFile(xlsxfile).then((rows) => {
        console.log("rows:", rows)
        for(var i=0;i<rows.length;i++){
            var data = {
                ProductName: rows[i][0], 
                Price: parseInt(rows[i][1]), 
                CategoryId: this.getCategoryId(rows[i][2]), 
                WholeSalerUserId : this.wholeSalerUserId,
                Quantity : rows[i][3],
                StockType : rows[i][4],
                Description : rows[i][5]
            }
            this.dataArray.push(data)
        }
        console.log(this.dataArray);
        })
    },
    getCategoryId(categoryName){
        if(categoryName=="Gıda") return 1;
        else if(categoryName=="Temizlik") return 2;
        else if(categoryName=="Giyim") return 3;
        else if(categoryName=="Şarküteri") return 4;
    }
  },
  created(){
    axios.get("https://localhost:7185/api/WholeSalerUsers/getId/"+this.userId)
    .then(response=>{
        console.log(response)
        this.wholeSalerUserId = response.data;
    })
  }
}
/*
                    ProductName : this.productName,
                    Price : this.price,
                    Thumbnail : "empty",
                    CategoryId : this.category,
                    WholeSalerUserId : this.wholeSalerUserId,
                    StockId : response.data.id
*/

</script>