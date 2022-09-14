import { createRouter, createWebHistory } from '@ionic/vue-router';
import { RouteRecordRaw } from 'vue-router';
import HomePage from '../views/HomePage.vue'

const routes: Array<RouteRecordRaw> = [
  {
    path: '/',
    redirect: '/home'
  },
  {
    path: '/home',
    name: 'Home',
    component: HomePage
  },
  {
    path: '/message/:id',
    component: () => import('../views/ViewMessagePage.vue')
  },
  {
    path: '/sell',
    component: () => import('../views/SellPage.vue')
  },
  {
    path: '/sell-cart',
    component: () => import('../views/SellCartPage.vue')
  },
  {
    path: '/bid',
    component: () => import('../views/BidPage.vue')
  },
  {
    path: '/bid-cart',
    component: () => import('../views/BidCartPage.vue')
  },
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
