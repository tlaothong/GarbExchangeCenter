<template>

<ion-header :translucent="true">
      <ion-toolbar>
        <ion-title>Sell</ion-title>
      </ion-toolbar>
    </ion-header>

    <ion-content>

      <div class="bg-white">
        <div class="mx-auto max-w-2xl py-4 px-4 sm:py-24 sm:px-6 lg:max-w-7xl lg:px-8">
          <h2 class="text-2xl font-bold tracking-tight text-gray-900">เลือกสินค้าที่ต้องการขาย</h2>

          <div class="mt-6 grid grid-cols-2 gap-y-10 gap-x-6 sm:grid-cols-2 lg:grid-cols-4 xl:gap-x-8">
            <div class="group relative">
              <div
                class="min-h-8 aspect-w-1 aspect-h-1 w-full overflow-hidden rounded-md bg-gray-200 group-hover:opacity-75 lg:aspect-none lg:h-80">
                <img src="/assets/images/a2.jpg" alt="Front of men&#039;s Basic Tee in black."
                  class="h-full w-full object-cover object-center lg:h-full lg:w-full">
              </div>
              <div class="mt-4 flex justify-between">
                <div>
                  <h3 class="text-sm text-gray-700">
                    <ion-nav-link router-direction="forward" :component="cart">
                      <span aria-hidden="true" class="absolute inset-0"></span>
                      เศษเหล็ก
                    </ion-nav-link>
                  </h3>
                  <p class="mt-1 text-sm text-gray-500">(ราคาขายต่อ กก.)</p>
                </div>
                <p class="text-sm font-medium text-gray-900">฿5</p>
              </div>
            </div>

            <!-- More products... -->
            <div class="group relative">
              <div
                class="min-h-80 aspect-w-1 aspect-h-1 w-full overflow-hidden rounded-md bg-gray-200 group-hover:opacity-75 lg:aspect-none lg:h-80">
                <img src="/assets/images/b4.jpg" alt="Front of men&#039;s Basic Tee in black."
                  class="h-full w-full object-cover object-center lg:h-full lg:w-full">
              </div>
              <div class="mt-4 flex justify-between">
                <div>
                  <h3 class="text-sm text-gray-700">
                    <ion-nav-link router-direction="forward" :component="cart">
                      <span aria-hidden="true" class="absolute inset-0"></span>
                      พลาสติก
                    </ion-nav-link>
                  </h3>
                  <p class="mt-1 text-sm text-gray-500">(ราคาขายต่อ กก.)</p>
                </div>
                <p class="text-sm font-medium text-gray-900">฿7</p>
              </div>
            </div>

            <!-- More products... -->
            <div class="group relative">
              <div
                class="min-h-80 aspect-w-1 aspect-h-1 w-full overflow-hidden rounded-md bg-gray-200 group-hover:opacity-75 lg:aspect-none lg:h-80">
                <img src="/assets/images/c6.jpg" alt="Front of men&#039;s Basic Tee in black."
                  class="h-full w-full object-cover object-center lg:h-full lg:w-full">
              </div>
              <div class="mt-4 flex justify-between">
                <div>
                  <h3 class="text-sm text-gray-700">
                    <a href="#">
                      <span aria-hidden="true" class="absolute inset-0"></span>
                      ขวดแก้ว
                    </a>
                  </h3>
                  <p class="mt-1 text-sm text-gray-500">(ราคาขายต่อ กก.)</p>
                </div>
                <p class="text-sm font-medium text-gray-900">฿9</p>
              </div>
            </div>

            <!-- More products... -->
            <div class="group relative">
              <div
                class="min-h-80 aspect-w-1 aspect-h-1 w-full overflow-hidden rounded-md bg-gray-200 group-hover:opacity-75 lg:aspect-none lg:h-80">
                <img src="/assets/images/d8.jpg" alt="Front of men&#039;s Basic Tee in black."
                  class="h-full w-full object-cover object-center lg:h-full lg:w-full">
              </div>
              <div class="mt-4 flex justify-between">
                <div>
                  <h3 class="text-sm text-gray-700">
                    <a href="#">
                      <span aria-hidden="true" class="absolute inset-0"></span>
                      เศษกระดาษ
                    </a>
                  </h3>
                  <p class="mt-1 text-sm text-gray-500">(ราคาขายต่อ กก.)</p>
                </div>
                <p class="text-sm font-medium text-gray-900">฿4</p>
              </div>
            </div>

          </div>
        </div>
      </div>

    </ion-content>

</template>

<script lang="ts">
import { defineComponent } from 'vue';
import { IonNavLink } from '@ionic/vue';
import SellProductPageVue from './SellProductPage.vue';

export default defineComponent({
  components: { IonNavLink },
  setup() {
    return {
      cart: SellProductPageVue
    }
  }
});
</script>

<style scoped>
</style>