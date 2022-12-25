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
            <th scope="row">{{ supplier.user.firstName }} {{supplier.user.lastName}}</th>
            <td>{{ supplier.companyName }}</td>
            <td>{{ supplier.user.city }}</td>
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
      }
    },
    created() {
      axios.get("https://localhost:7185/api/WholeSalerUsers")
      .then(response=>{
        console.log(response)
        this.suppliers = response.data;
      })
    }

}

</script>
