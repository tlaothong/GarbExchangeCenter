<template>

  <ion-header :translucent="true">
    <ion-toolbar>
      <ion-title>Bid</ion-title>
    </ion-toolbar>
  </ion-header>

  <ion-content>

    <div class="bg-white">
      <div class="mx-auto max-w-2xl py-4 px-4 sm:py-24 sm:px-6 lg:max-w-7xl lg:px-8">
        <h2 class="text-2xl font-bold tracking-tight text-gray-900">ใส่ข้อมูลข้อเสนอซื้อ</h2>

        <div class="mt-6 grid grid-cols-1 gap-y-0 gap-x-6 sm:grid-cols-1 lg:grid-cols-2 xl:gap-x-8">
          <div class="group relative">
            <div
              class="min-h-8 aspect-w-1 aspect-h-1 w-full overflow-hidden rounded-md bg-gray-200 lg:aspect-none lg:h-80">
              <img src="/assets/images/a2.jpg" alt="Front of men&#039;s Basic Tee in black."
                class="h-full w-full object-cover object-center lg:h-full lg:w-full">
            </div>
            <div class="mt-4 flex justify-between">
              <div>
                <h3 class="text-sm text-gray-700">
                  กระป๋อง
                </h3>
                <p class="mt-1 text-sm text-gray-500">(ราคาเสนอต่อ กก.)</p>
              </div>
              <p class="text-sm font-medium text-gray-900">฿5 - (4)</p>
            </div>
          </div>

          <!-- Product info -->
          <div
            class="mx-auto px-4 pt-4 pb-16 sm:px-4 lg:gap-x-8 lg:px-8 lg:pt-0 lg:pb-24">

            <!-- Options -->
            <div class="mt-4 lg:mt-0">
              <h2 class="sr-only">Product information</h2>
              <p class="text-3xl tracking-tight text-gray-900">$800</p>

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
                  <a href="#" class="ml-3 text-sm font-medium text-indigo-600 hover:text-indigo-500">117 reviews</a>
                </div>
              </div>

              <form class="mt-10" novalidate @submit.prevent="goCart">
                <!-- Colors -->
                <div>
                  <h3 class="text-sm font-medium text-gray-900">Color</h3>

                  <fieldset class="mt-4">
                    <legend class="sr-only">Choose a color</legend>
                    <div class="flex items-center space-x-3">
                      <!--
                  Active and Checked: "ring ring-offset-1"
                  Not Active and Checked: "ring-2"
                -->
                      <label
                        class="-m-0.5 relative p-0.5 rounded-full flex items-center justify-center cursor-pointer focus:outline-none ring-gray-400">
                        <input type="radio" name="color-choice" value="White" class="sr-only"
                          aria-labelledby="color-choice-0-label">
                        <span id="color-choice-0-label" class="sr-only"> White </span>
                        <span aria-hidden="true"
                          class="h-8 w-8 bg-white border border-black border-opacity-10 rounded-full"></span>
                      </label>

                      <!--
                  Active and Checked: "ring ring-offset-1"
                  Not Active and Checked: "ring-2"
                -->
                      <label
                        class="-m-0.5 relative p-0.5 rounded-full flex items-center justify-center cursor-pointer focus:outline-none ring-gray-400">
                        <input type="radio" name="color-choice" value="Gray" class="sr-only"
                          aria-labelledby="color-choice-1-label">
                        <span id="color-choice-1-label" class="sr-only"> Gray </span>
                        <span aria-hidden="true"
                          class="h-8 w-8 bg-gray-200 border border-black border-opacity-10 rounded-full"></span>
                      </label>

                      <!--
                  Active and Checked: "ring ring-offset-1"
                  Not Active and Checked: "ring-2"
                -->
                      <label
                        class="-m-0.5 relative p-0.5 rounded-full flex items-center justify-center cursor-pointer focus:outline-none ring-gray-900">
                        <input type="radio" name="color-choice" value="Black" class="sr-only"
                          aria-labelledby="color-choice-2-label">
                        <span id="color-choice-2-label" class="sr-only"> Black </span>
                        <span aria-hidden="true"
                          class="h-8 w-8 bg-gray-900 border border-black border-opacity-10 rounded-full"></span>
                      </label>
                    </div>
                  </fieldset>
                </div>

                <!-- Sizes -->
                <div class="mt-10">
                  <div class="flex items-center justify-between">
                    <h3 class="text-sm font-medium text-gray-900">Size</h3>
                    <a href="#" class="text-sm font-medium text-indigo-600 hover:text-indigo-500">Size guide</a>
                  </div>

                  <fieldset class="mt-4">
                    <legend class="sr-only">Choose a size</legend>
                    <div class="grid grid-cols-4 gap-4 sm:grid-cols-8 lg:grid-cols-4">
                      <!-- Active: "ring-2 ring-indigo-500" -->
                      <label
                        class="group relative border rounded-md py-3 px-4 flex items-center justify-center text-sm font-medium uppercase hover:bg-gray-50 focus:outline-none sm:flex-1 sm:py-6 bg-gray-50 text-gray-200 cursor-not-allowed">
                        <input type="radio" name="size-choice" value="XXS" disabled class="sr-only"
                          aria-labelledby="size-choice-0-label">
                        <span id="size-choice-0-label">XXS</span>

                        <span aria-hidden="true"
                          class="pointer-events-none absolute -inset-px rounded-md border-2 border-gray-200">
                          <svg class="absolute inset-0 h-full w-full stroke-2 text-gray-200" viewBox="0 0 100 100"
                            preserveAspectRatio="none" stroke="currentColor">
                            <line x1="0" y1="100" x2="100" y2="0" vector-effect="non-scaling-stroke" />
                          </svg>
                        </span>
                      </label>

                      <!-- Active: "ring-2 ring-indigo-500" -->
                      <label
                        class="group relative border rounded-md py-3 px-4 flex items-center justify-center text-sm font-medium uppercase hover:bg-gray-50 focus:outline-none sm:flex-1 sm:py-6 bg-white shadow-sm text-gray-900 cursor-pointer">
                        <input type="radio" name="size-choice" value="XS" class="sr-only"
                          aria-labelledby="size-choice-1-label">
                        <span id="size-choice-1-label">XS</span>

                        <!--
                    Active: "border", Not Active: "border-2"
                    Checked: "border-indigo-500", Not Checked: "border-transparent"
                  -->
                        <span class="pointer-events-none absolute -inset-px rounded-md" aria-hidden="true"></span>
                      </label>

                      <!-- Active: "ring-2 ring-indigo-500" -->
                      <label
                        class="group relative border rounded-md py-3 px-4 flex items-center justify-center text-sm font-medium uppercase hover:bg-gray-50 focus:outline-none sm:flex-1 sm:py-6 bg-white shadow-sm text-gray-900 cursor-pointer">
                        <input type="radio" name="size-choice" value="S" class="sr-only"
                          aria-labelledby="size-choice-2-label">
                        <span id="size-choice-2-label">S</span>

                        <!--
                    Active: "border", Not Active: "border-2"
                    Checked: "border-indigo-500", Not Checked: "border-transparent"
                  -->
                        <span class="pointer-events-none absolute -inset-px rounded-md" aria-hidden="true"></span>
                      </label>

                      <!-- Active: "ring-2 ring-indigo-500" -->
                      <label
                        class="group relative border rounded-md py-3 px-4 flex items-center justify-center text-sm font-medium uppercase hover:bg-gray-50 focus:outline-none sm:flex-1 sm:py-6 bg-white shadow-sm text-gray-900 cursor-pointer">
                        <input type="radio" name="size-choice" value="M" class="sr-only"
                          aria-labelledby="size-choice-3-label">
                        <span id="size-choice-3-label">M</span>

                        <!--
                    Active: "border", Not Active: "border-2"
                    Checked: "border-indigo-500", Not Checked: "border-transparent"
                  -->
                        <span class="pointer-events-none absolute -inset-px rounded-md" aria-hidden="true"></span>
                      </label>

                      <!-- Active: "ring-2 ring-indigo-500" -->
                      <label
                        class="group relative border rounded-md py-3 px-4 flex items-center justify-center text-sm font-medium uppercase hover:bg-gray-50 focus:outline-none sm:flex-1 sm:py-6 bg-white shadow-sm text-gray-900 cursor-pointer">
                        <input type="radio" name="size-choice" value="L" class="sr-only"
                          aria-labelledby="size-choice-4-label">
                        <span id="size-choice-4-label">L</span>

                        <!--
                    Active: "border", Not Active: "border-2"
                    Checked: "border-indigo-500", Not Checked: "border-transparent"
                  -->
                        <span class="pointer-events-none absolute -inset-px rounded-md" aria-hidden="true"></span>
                      </label>

                      <!-- Active: "ring-2 ring-indigo-500" -->
                      <label
                        class="group relative border rounded-md py-3 px-4 flex items-center justify-center text-sm font-medium uppercase hover:bg-gray-50 focus:outline-none sm:flex-1 sm:py-6 bg-white shadow-sm text-gray-900 cursor-pointer">
                        <input type="radio" name="size-choice" value="XL" class="sr-only"
                          aria-labelledby="size-choice-5-label">
                        <span id="size-choice-5-label">XL</span>

                        <!--
                    Active: "border", Not Active: "border-2"
                    Checked: "border-indigo-500", Not Checked: "border-transparent"
                  -->
                        <span class="pointer-events-none absolute -inset-px rounded-md" aria-hidden="true"></span>
                      </label>

                      <!-- Active: "ring-2 ring-indigo-500" -->
                      <label
                        class="group relative border rounded-md py-3 px-4 flex items-center justify-center text-sm font-medium uppercase hover:bg-gray-50 focus:outline-none sm:flex-1 sm:py-6 bg-white shadow-sm text-gray-900 cursor-pointer">
                        <input type="radio" name="size-choice" value="2XL" class="sr-only"
                          aria-labelledby="size-choice-6-label">
                        <span id="size-choice-6-label">2XL</span>

                        <!--
                    Active: "border", Not Active: "border-2"
                    Checked: "border-indigo-500", Not Checked: "border-transparent"
                  -->
                        <span class="pointer-events-none absolute -inset-px rounded-md" aria-hidden="true"></span>
                      </label>

                      <!-- Active: "ring-2 ring-indigo-500" -->
                      <label
                        class="group relative border rounded-md py-3 px-4 flex items-center justify-center text-sm font-medium uppercase hover:bg-gray-50 focus:outline-none sm:flex-1 sm:py-6 bg-white shadow-sm text-gray-900 cursor-pointer">
                        <input type="radio" name="size-choice" value="3XL" class="sr-only"
                          aria-labelledby="size-choice-7-label">
                        <span id="size-choice-7-label">3XL</span>

                        <!--
                    Active: "border", Not Active: "border-2"
                    Checked: "border-indigo-500", Not Checked: "border-transparent"
                  -->
                        <span class="pointer-events-none absolute -inset-px rounded-md" aria-hidden="true"></span>
                      </label>
                    </div>
                  </fieldset>
                </div>

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
      router.navigate('/bid-cart');
    }
    return {
      // cart: BidCartPageVue,
      goCart,
    }
  }
});
</script>
  
<style scoped>

</style>