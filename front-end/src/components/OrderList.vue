<template>
    <table class="table table-striped table-hover" >
      <thead>
        <tr >
          <th scope="col">Sipariş Numarası</th>
          <th v-if="userRole==1" scope="col">Toptancı Adı</th>
          <th v-if="userRole==2" scope="col">Market Adı</th>
          <th scope="col">Teslimat Durumu</th>
          <th scope="col">Toplam Tutar</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="order in orders">
          <th scope="row">{{ order.id }}</th>
          <td v-if="userRole==1">{{ order.wholeSalerUser.companyName }}</td>
          <td v-if="userRole==2">{{ order.groceryStoreUser.storeName }}</td>
          <td>{{ order.deliveryStatus }}</td>
          <td>{{ order.totalPrice }}</td>
          <div class="d-flex justify-content-end">
              <button class="btn bg-primary text-white" @click="total=order.totalPrice; fetchItems(order.orderItems);">Sipariş Detayları</button>
          </div>
        </tr>
      </tbody>
    </table>
    <OrderDetails v-if="isDetailsOpen" 
    :orderItems="orderItems"
    :total="total"
    v-on:handleDetails="handleDetails()"
  />
</template>


<script>
import axios from 'axios';
import OrderDetails from './OrderDetails.vue';
export default {
    name: "OrderList",
    data() {
        return {
            user: {},
            orders: [],
            orderItems:[],
            isDetailsOpen:false,
            total : 0
        };
    },
    components: {
      OrderDetails
    },
    props: {
        userRole: Number,
        userId: Number
    },
    created() {
        this.fetchData();
    },
    methods: {
        fetchData() {
            console.log(this.userRole);
            if (this.userRole == 1) {
                axios.get("https://localhost:7185/api/GroceryStoreUsers/getByUserId/" + this.userId)
                    .then(response => {
                    console.log(response);
                    axios.get("https://localhost:7185/api/Orders/byGsId/" + response.data.id)
                        .then(response2 => {
                        console.log(response2);
                        this.orders = response2.data;
                    });
                });
            }
            else if (this.userRole == 2) {
                axios.get("https://localhost:7185/api/WholeSalerUsers/getId/" + this.userId)
                    .then(response => {
                    console.log(response);
                    axios.get("https://localhost:7185/api/Orders/byWsId/" + response.data)
                        .then(response2 => {
                        console.log(response2);
                        this.orders = response2.data;
                    });
                });
            }
        },
        fetchItems(orderItems){
          this.handleDetails();
          this.orderItems = orderItems;
        },
        handleDetails(){
          this.isDetailsOpen = this.isDetailsOpen ? false : true
        }

    },
    components: { OrderDetails }
}

</script>
