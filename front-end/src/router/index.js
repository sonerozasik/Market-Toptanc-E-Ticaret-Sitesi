import { createRouter, createWebHistory } from 'vue-router'
import LoginForm from '../components/LoginForm.vue'
import SignUpForm from '../components/SignupForm.vue'
import SupplierList from '../components/SupplierList.vue'
import ProductList from '../components/ProductList.vue'
import OrderList from '../components/OrderList.vue'
import AddProduct from '../components/AddProduct.vue'

const routes = [
  {
    path: '/login',
    name: 'login',
    component: LoginForm
  },
  {
    path: '/signup',
    name: 'signup',
    component : SignUpForm
  },
  {
    path: '/supplier-list',
    name: 'supplier-list',
    component : SupplierList
  },
  {
    path: '/product-list',
    name: 'product-list',
    component : ProductList
  },
  {
    path: '/order-list',
    name: 'order-list',
    component : OrderList
  },
  {
    path: '/add-product',
    name: 'add-product',
    component : AddProduct
  }
]

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes
})

export default router