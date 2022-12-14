<template>
    <table class="table table-striped table-hover" >
      <thead>
        <tr >
          <th scope="col">Sipariş Numarası</th>
          <th scope="col">Market Adı</th>
          <th scope="col">Sipariş Tarihi</th>
          <th scope="col">Teslimat Durumu</th>
          <th scope="col">Toplam Tutar</th>

        </tr>
      </thead>
      <tbody>
        <tr v-for="order in orders">
          <th scope="row">{{ order.id }}</th>
          <td>{{ order.groceryname }}</td>
          <td>{{ order.date }}</td>
          <td>{{ order.deliverystatus }}</td>
          <td>{{ order.totalcost }}</td>
          <div class="d-flex justify-content-end">
              <button class="btn bg-primary text-white">Sipariş Detayları</button>
          </div>
        </tr>
      </tbody>
    </table>
</template>


<script>
export default {
  name: "OrderList",
  data() {
    return {
      orders: [
        {id:12156,groceryname:"Ali Gıda",deliverystatus:"Yolda",totalcost:1299.99,date:"12-12-2022 12:59"},
        {id:12157,groceryname:"Veli Gıda",deliverystatus:"Teslim Edildi",totalcost:5255.69,date:"10-11-2022 09:12"},
        {id:12158,groceryname:"Ziya Market",deliverystatus:"Hazırlanıyor",totalcost:219.29,date:"11-12-2022 21:13"},

    ]
    }
  },
  created() {
    // Burada toptancıların listesini yükleyebilirsiniz
    // Örneğin, bir HTTP isteği ile bir API'dan verileri alabilirsiniz
  }

}

</script>
