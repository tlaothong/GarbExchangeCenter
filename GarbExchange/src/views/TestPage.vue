<template>
  <ion-page>

    <ion-content>

      <ion-list>
        <ion-item>
          <ion-label>Hello</ion-label>
        </ion-item>
        <ion-item>
          <ion-label>Opening Date</ion-label>
          <ion-datetime-button datetime="datetime"></ion-datetime-button>
        </ion-item>
        <ion-item>
          <ion-label>Closing Date</ion-label>
          <ion-datetime-button datetime="closeTime"></ion-datetime-button>
        </ion-item>
      </ion-list>

      <ion-modal :keep-contents-mounted="true">
        <div class="p-4">
          <ion-text class="text-lg">
            Opening
          </ion-text>
          <ion-datetime id="datetime" presentation="time" hour-cycle="h23"></ion-datetime>
        </div>
      </ion-modal>

      <ion-modal :keep-contents-mounted="true">
        <div class="p-4">
          <ion-text class="text-lg">
            Closing
          </ion-text>
          <ion-datetime id="closeTime" presentation="time" hour-cycle="h23"></ion-datetime>
        </div>
      </ion-modal>

      <ion-button id="open-modal" expand="block">Open Sheet Modal</ion-button>

      <ion-modal trigger="open-modal" :initial-breakpoint="0.5" :breakpoints="[0.5, 0.55]" :handle="false"
        handle-behavior="cycle">
        <ion-header>
          <ion-toolbar>
            <ion-title>
              Opening Date
            </ion-title>
          </ion-toolbar>
        </ion-header>
        <ion-content class="ion-padding">
          <ion-datetime presentation="time" hour-cycle="h23"></ion-datetime>
          <ion-footer>
            <ion-button expand="block">
              OK
            </ion-button>
          </ion-footer>
        </ion-content>
      </ion-modal>

    </ion-content>

  </ion-page>
</template>


<script lang="ts">
import {
  IonModal,
  IonDatetime,
} from '@ionic/vue';
import { defineComponent } from 'vue';

export default defineComponent({
  components: {
    IonModal,
    IonDatetime,
  },
});
</script>
