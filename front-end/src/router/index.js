import { createRouter, createWebHistory } from 'vue-router'
import LoginForm from '../components/LoginForm.vue'
import SignUpForm from '../components/SignupForm.vue'
import SupplierList from '../components/SupplierList.vue'
import ProductList from '../components/ProductList.vue'


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
  }
]

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes
})

export default router