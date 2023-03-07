<template>
  <div class="products">
    
    <div v-for="item in Products" class="main" :key="item.id" @click="showModal(item)">
      <img class="img-item-sm" :src=getImage(item)>
      <div class="pl-3">{{item.name}}</div>
      <div class="pl-3">{{item.type}}</div>
    </div>

    <ProductModal v-if="isModalVisible"
      :Product="product"
      v-show="isModalVisible"
      @close="closeModal"
    />
  </div>
</template>

<script>
import ProductModal from './ProductModal.vue'

export default {
  props: ['Products'],
  name: 'Card',
  components: {
    ProductModal
  },
  data() {
    return {
      isModalVisible: false,
      product: {}
    };
  },
  methods: {
    addtoCart(it) {
     this.$store.commit('inCart', it)
    },
    sendInfo(it) {
     this.$store.commit('addtoInfo', it)
    },
    getImage(item){
      return require('@/assets/products/'+item.image)
    },
    showModal(item) {
      this.product = item;
      this.isModalVisible = true;
    },
    closeModal() {
      this.isModalVisible = false;
    }
  }
}
</script>

<style scoped>


  .products {
    display: grid;
    grid-template-columns: repeat(3, 1fr);
    padding-top: 1%;
    padding-left: 10%;
  }

  .main{
    font-family: Helvetica Neue;
    font-size: 21px;
    font-weight: bold;
    justify-content: space-between;
  }

  .main:hover{
    opacity: .5;
  }

  .img-item-sm {
      height: 70%;
      width: 65%;
      background-color: #ffff;
      border-radius: 20%;
  }

</style>
