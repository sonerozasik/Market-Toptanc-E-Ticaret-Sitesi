<template>
      <table class="table table-striped table-hover" >
        <thead>
          <tr >
            <th scope="col">Toptancı Adı</th>
            <th scope="col">Toptancı Açıklaması</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="supplier in suppliers">
            <th scope="row">{{ supplier.name }}</th>
            <td>{{ supplier.description }}</td>
            <div class="d-flex justify-content-end">
                <button class="btn bg-primary text-white">Ürünleri Gör!</button>
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
        suppliers: [{name:"Toptancı 1",description:"açıklama 1"},{name:"Toptancı 2",description:"açıklama 2"},{name:"Toptancı 3",description:"açıklama 3"}]
      }
    },
    created() {
      // Burada toptancıların listesini yükleyebilirsiniz
      // Örneğin, bir HTTP isteği ile bir API'dan verileri alabilirsiniz
    }

}

</script>
