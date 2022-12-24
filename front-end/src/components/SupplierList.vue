<template>
      <table class="table table-striped table-hover" >
        <thead>
          <tr >
            <th scope="col">Toptancı Adı</th>
            <th scope="col">Şirket Adı</th>
            <th scope="col">Şirket Adresi</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="supplier in suppliers">
            <th scope="row">{{ supplier.firstName }} {{supplier.lastName}}</th>
            <td>{{ supplierCompanyNames[supplier.id] }}</td>
            <td>{{ supplier.city }}</td>
            <div class="d-flex justify-content-end">
                <button class="btn bg-primary text-white">Ürünleri Gör</button>
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
        suppliers: [ ],
        supplierCompanyNames:[]
      }
    },
    created() {
      axios.get("https://localhost:7185/api/WholeSalerUsers")
      .then(response=>{
        console.log(response)
        for(var i=0;i<response.data.length;i++){
          this.supplierCompanyNames[response.data[i].userId] = response.data[i].companyName
          axios.get("https://localhost:7185/api/Users/"+response.data[i].userId)
          .then(response2=>{
            console.log(response2)
            this.suppliers.push(response2.data)
          })
        }
      })
    }

}

</script>
