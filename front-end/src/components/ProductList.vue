<template>
    <table class="table" >
        <thead>
          <tr >
            <th scope="col">Ürün Adı</th>
            <th scope="col">Minimum Fiyat</th>
            <th scope="col">Maksimum Fiyat</th>
            <th scope="col">Ürün Toptancısı</th>
            <th scope="col">Kategori</th>  

          </tr>
        </thead>
        <tbody>
          <tr>
            <td><input type="text" style="width:200px" placeholder="Ürün Adı"> </td>
            <td><input type="number" style="width:100px" @keypress="control($event)" placeholder="0" min="0"> </td>
            <td><input type="number" style="width:100px" @keypress="control($event)" placeholder="0" min="0"> </td>
            <td><input type="text" style="width:200px" placeholder="Toptancı"> </td>
            <td><select name="category" id="category" >
              <option value="all">Hepsi</option>
              <option v-for="category in categories" v-bind:value="category.id">{{category.name}}</option>
            </select> </td>
            <div class="d-flex justify-content-end">
                <button class="btn bg-primary text-white">Filtrele</button>
            </div>
          </tr>
        </tbody>
      </table>

    <table class="table table-striped" >
      <thead>
        <tr >
          <th scope="col">Ürün Kodu</th>
          <th scope="col">Ürün Adı</th>
          <th scope="col">Fiyatı</th>
          <th scope="col">Toptancı</th>
          <th scope="col">Stok Türü</th>
          <th scope="col" >Miktar</th>
          <th scope="col"></th>

        </tr>
      </thead>
      <tbody>
        <tr v-for="product in products">
          <th scope="row">{{ product.id }}</th>
          <td>{{ product.productName }}</td>
          <td>{{ product.price }}</td>
          <td>{{ product.wholeSalerUser.companyName }}</td>
          <td>{{ product.stock.quantity }} {{ product.stock.stockType }}</td>
          <td><input type="number" style="width:100px" @keypress="control($event)" placeholder="0" min="0"> </td>
          <div class="d-flex justify-content-end">
              <button class="btn bg-primary text-white">Sepete Ekle!</button>
          </div>
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
      categories : [ ]
    }
    
  },
  created() {
    axios.get("https://localhost:7185/api/Categories")
    .then(response=>{
        console.log(response)
        this.categories = response.data
    })
    axios.get("https://localhost:7185/api/Products")
    .then(response=>{
        console.log(response)
        this.products = response.data
    })
  },
  methods:{
    control(evt){
        if (evt.which != 8 && evt.which != 0 && evt.which < 48 || evt.which > 57)
        {
            evt.preventDefault();
        }
    }
}

}


</script>

<style>
    

</style>