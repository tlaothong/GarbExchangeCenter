<template>
  <ion-page>
    <ion-nav :root="catalog"></ion-nav>
  </ion-page>
</template>

<script lang="ts">
import { defineComponent } from 'vue';
import { IonNav } from '@ionic/vue';
import BidCatalogPageVue from './BidCatalogPage.vue';

export default defineComponent({
  components: { IonNav },
  setup() {
    return {
      catalog: BidCatalogPageVue
    };
  }
});
</script>