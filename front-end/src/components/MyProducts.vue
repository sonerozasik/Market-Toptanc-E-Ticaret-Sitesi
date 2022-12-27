<template>
    <table class="table table-striped" >
      <thead>
        <tr >
          <th scope="col">Ürün Kodu</th>
          <th scope="col">Ürün Adı</th>
          <th scope="col">Fiyatı</th>
          <th scope="col">Stok Miktarı</th>
          <th scope="col">Stok Türü</th>
          <th scope="col"></th>
          <th scope="col"></th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="product in products">
          <th scope="row">{{product.id}}</th>
          <td><input class="form-control" type="text" :ref="'name'+product.id" v-bind:value="product.productName"></td>
          <td><input class="form-control" type="number" :ref="'price'+product.id" v-bind:value="product.price"></td>
          <td><input class="form-control" type="number" :ref="'stock'+product.id" @keypress="control($event)" v-bind:value="product.stock.quantity"></td>
          <td><input class="form-control" type="text" :ref="'type'+product.id" v-bind:value="product.stock.stockType"></td>
          <td>
            <div class="d-flex justify-content-end">
                <button class="btn bg-success text-white" @click="updateItem(product)">Güncelle!</button>
            </div>
        </td>
        <td>
            <div class="d-flex justify-content-end">
                <button class="btn bg-danger text-white" @click="deleteItem(product.id)">Sil!</button>
            </div>
        </td>
          
          
        </tr>
      </tbody>
    </table>
</template>


<script>
import axios from 'axios';
export default {
  name: "SupplierList",
  data() {
    return {
      products : [ ],
      categories : [ ],
      WSUId : 0,
    }
    
  },
  props:{
    userId : Number
  },
  created() {
    this.fetchData();
  },
  mounted(){
    
  },
  methods:{
    control(evt){
        if (evt.which != 8 && evt.which != 0 && evt.which < 48 || evt.which > 57)
        {
            evt.preventDefault();
        }
    },
    deleteItem(id){
        axios.delete("https://localhost:7185/api/Products/"+id)
        .then(response=>{
            console.log(response);
            this.fetchData();
        }).catch(e=>console.log(e));
    },
    fetchData(){
        axios.get("https://localhost:7185/api/WholeSalerUsers/getId/"+this.userId)
        .then(response=>{
        console.log(response)
        this.WSUId = response.data;
            axios.get("https://localhost:7185/api/Products/byWSUId/"+this.WSUId)
            .then(response=>{
                console.log(response)
                this.products = response.data
            })
        })
    },
    updateItem(product){
        var strProductName = 'name' + product.id
        var strProductPrice = 'price' + product.id
        var strProductStock = 'stock' + product.id
        var strProductType= 'type' + product.id
        var stock = 
        {   
            Id : product.stock.id,
            Quantity : this.$refs[strProductStock][0].value,
            StockType : this.$refs[strProductType][0].value,
            Description : product.stock.description
        }

        axios.put("https://localhost:7185/api/Products",
        {
            Id: product.id,
            ProductName : this.$refs[strProductName][0].value,
            Price : this.$refs[strProductPrice][0].value,
            Thumbnail : "empty",
            CategoryId : product.categoryId,
            WholeSalerUserId : product.wholeSalerUserId,
            StockId : product.stockId,
            Stock : stock
        })
        .then(response=>{
            console.log(response)
            this.fetchData();
        })
    }
}

}


</script>

<style>
    

</style>