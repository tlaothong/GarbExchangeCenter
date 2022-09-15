<template>

  <ion-header :translucent="true">
    <ion-toolbar>
      <ion-title>Sell</ion-title>
    </ion-toolbar>
  </ion-header>

  <ion-content>

    <div class="bg-white">
      <div class="mx-auto max-w-2xl py-4 px-4 sm:py-24 sm:px-6 lg:max-w-7xl lg:px-8">
        <h2 class="text-2xl font-bold tracking-tight text-gray-900">ใส่ข้อมูลสินค้าที่ต้องการขาย</h2>

        <div class="mt-6 grid grid-cols-1 gap-y-0 gap-x-6 sm:grid-cols-1 lg:grid-cols-2 xl:gap-x-8">
          <div class="group relative">
            <div
              class="min-h-8 aspect-w-1 aspect-h-1 w-full overflow-hidden rounded-md bg-gray-200 lg:aspect-none lg:h-80">
              <img src="/assets/images/b4.jpg" alt="Front of men&#039;s Basic Tee in black."
                class="h-full w-full object-cover object-center lg:h-full lg:w-full">
            </div>
            <div class="mt-4 flex justify-between">
              <div>
                <h3 class="text-sm text-gray-700">
                  พลาสติก
                </h3>
                <p class="mt-1 text-sm text-gray-500">(ราคาขายต่อ กก.)</p>
              </div>
              <p class="text-sm font-medium text-gray-900">฿7</p>
            </div>
          </div>

          <!-- Product info -->
          <div
            class="mx-auto px-4 pt-4 pb-16 sm:px-4 lg:gap-x-8 lg:px-8 lg:pt-0 lg:pb-24">

            <!-- Options -->
            <div class="mt-4 lg:mt-0">
              <h2 class="sr-only">Product information</h2>
              <p class="text-3xl tracking-tight text-gray-900">$350</p>

              <!-- Reviews -->
              <div class="mt-6">
                <h3 class="sr-only">Reviews</h3>
                <div class="flex items-center">
                  <div class="flex items-center">
                    <!--
                Heroicon name: mini/star

                Active: "text-gray-900", Default: "text-gray-200"
              -->
                    <svg class="text-gray-900 h-5 w-5 flex-shrink-0" xmlns="http://www.w3.org/2000/svg"
                      viewBox="0 0 20 20" fill="currentColor" aria-hidden="true">
                      <path fill-rule="evenodd"
                        d="M10.868 2.884c-.321-.772-1.415-.772-1.736 0l-1.83 4.401-4.753.381c-.833.067-1.171 1.107-.536 1.651l3.62 3.102-1.106 4.637c-.194.813.691 1.456 1.405 1.02L10 15.591l4.069 2.485c.713.436 1.598-.207 1.404-1.02l-1.106-4.637 3.62-3.102c.635-.544.297-1.584-.536-1.65l-4.752-.382-1.831-4.401z"
                        clip-rule="evenodd" />
                    </svg>

                    <!-- Heroicon name: mini/star -->
                    <svg class="text-gray-900 h-5 w-5 flex-shrink-0" xmlns="http://www.w3.org/2000/svg"
                      viewBox="0 0 20 20" fill="currentColor" aria-hidden="true">
                      <path fill-rule="evenodd"
                        d="M10.868 2.884c-.321-.772-1.415-.772-1.736 0l-1.83 4.401-4.753.381c-.833.067-1.171 1.107-.536 1.651l3.62 3.102-1.106 4.637c-.194.813.691 1.456 1.405 1.02L10 15.591l4.069 2.485c.713.436 1.598-.207 1.404-1.02l-1.106-4.637 3.62-3.102c.635-.544.297-1.584-.536-1.65l-4.752-.382-1.831-4.401z"
                        clip-rule="evenodd" />
                    </svg>

                    <!-- Heroicon name: mini/star -->
                    <svg class="text-gray-900 h-5 w-5 flex-shrink-0" xmlns="http://www.w3.org/2000/svg"
                      viewBox="0 0 20 20" fill="currentColor" aria-hidden="true">
                      <path fill-rule="evenodd"
                        d="M10.868 2.884c-.321-.772-1.415-.772-1.736 0l-1.83 4.401-4.753.381c-.833.067-1.171 1.107-.536 1.651l3.62 3.102-1.106 4.637c-.194.813.691 1.456 1.405 1.02L10 15.591l4.069 2.485c.713.436 1.598-.207 1.404-1.02l-1.106-4.637 3.62-3.102c.635-.544.297-1.584-.536-1.65l-4.752-.382-1.831-4.401z"
                        clip-rule="evenodd" />
                    </svg>

                    <!-- Heroicon name: mini/star -->
                    <svg class="text-gray-900 h-5 w-5 flex-shrink-0" xmlns="http://www.w3.org/2000/svg"
                      viewBox="0 0 20 20" fill="currentColor" aria-hidden="true">
                      <path fill-rule="evenodd"
                        d="M10.868 2.884c-.321-.772-1.415-.772-1.736 0l-1.83 4.401-4.753.381c-.833.067-1.171 1.107-.536 1.651l3.62 3.102-1.106 4.637c-.194.813.691 1.456 1.405 1.02L10 15.591l4.069 2.485c.713.436 1.598-.207 1.404-1.02l-1.106-4.637 3.62-3.102c.635-.544.297-1.584-.536-1.65l-4.752-.382-1.831-4.401z"
                        clip-rule="evenodd" />
                    </svg>

                    <!-- Heroicon name: mini/star -->
                    <svg class="text-gray-200 h-5 w-5 flex-shrink-0" xmlns="http://www.w3.org/2000/svg"
                      viewBox="0 0 20 20" fill="currentColor" aria-hidden="true">
                      <path fill-rule="evenodd"
                        d="M10.868 2.884c-.321-.772-1.415-.772-1.736 0l-1.83 4.401-4.753.381c-.833.067-1.171 1.107-.536 1.651l3.62 3.102-1.106 4.637c-.194.813.691 1.456 1.405 1.02L10 15.591l4.069 2.485c.713.436 1.598-.207 1.404-1.02l-1.106-4.637 3.62-3.102c.635-.544.297-1.584-.536-1.65l-4.752-.382-1.831-4.401z"
                        clip-rule="evenodd" />
                    </svg>
                  </div>
                  <p class="sr-only">4 out of 5 stars</p>
                  <a href="#" class="ml-3 text-sm font-medium text-indigo-600 hover:text-indigo-500">102 reviews</a>
                </div>
              </div>

              <form class="mt-10" novalidate @submit.prevent="goCart">
                
                <ion-list>
                  <ion-item>
                    <ion-label>
                      สินค้าที่ต้องการขาย
                    </ion-label>
                    <ion-select placeholder="ระบุสินค้า">
                      <ion-select-option>ขวดน้ำ PET ใส</ion-select-option>
                      <ion-select-option>สายยางอ่อน</ion-select-option>
                      <ion-select-option>สายยางแข็ง</ion-select-option>
                    </ion-select>
                  </ion-item>
                  <ion-item>
                    <ion-label position="floating">
                      ราคาเสนอขาย (บาท/หน่วย)
                    </ion-label>
                    <ion-input></ion-input>
                  </ion-item>
                  <ion-item>
                    <ion-label position="floating">
                      จำนวน (กก.)
                    </ion-label>
                    <ion-input type="number"></ion-input>
                  </ion-item>
                  <ion-item>
                    <ion-label>
                      แนบภาพหลักฐาน
                    </ion-label>
                    <ion-input type="file"></ion-input>
                  </ion-item>
                </ion-list>

                <button type="submit"
                  class="mt-10 flex w-full items-center justify-center rounded-md border border-transparent bg-indigo-600 py-3 px-8 text-base font-medium text-white hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-indigo-500 focus:ring-offset-2">
                  Add to bag
                </button>
              </form>
            </div>

          </div>

        </div>
      </div>
    </div>

  </ion-content>

</template>
  
<script lang="ts">
import { defineComponent } from 'vue';
import { useIonRouter } from '@ionic/vue';

export default defineComponent({
  components: { },
  setup() {
    const router = useIonRouter();
    const goCart = () => {
      router.navigate('/sell-cart');
    }
    return {
      goCart,
    }
  }
});
</script>
  
<style scoped>

</style>