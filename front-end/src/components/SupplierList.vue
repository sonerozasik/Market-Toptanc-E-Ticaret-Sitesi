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
            <th scope="row">{{ supplier.namesurname }}</th>
            <td>{{ supplier.companyname }}</td>
            <td>{{ supplier.address }}</td>
            <div class="d-flex justify-content-end">
                <button class="btn bg-primary text-white">Ürünleri Gör</button>
            </div>
          </tr>
        </tbody>
      </table>
</template>


<script>
export default {
    name: "SupplierList",
    data() {
      return {
        suppliers: [
          {namesurname:"Ali Bakır",companyname:"Eti", address: "Tepebaşı/Eskişehir"},
          {namesurname:"Veli Gümüş",companyname:"Ülker", address: "Osmangazi/Bursa"},
          {namesurname:"Ahmet Demir",companyname:"Acord", address: "Gebze/Kocaeli"}
        ]
      }
    },
    created() {
      // Burada toptancıların listesini yükleyebilirsiniz
      // Örneğin, bir HTTP isteği ile bir API'dan verileri alabilirsiniz
    }

}

</script>
