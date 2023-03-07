<template>
  <div class="wrapper">
      <div class="divgrid">
        <Grid/>
      </div>
      <div class="divproduct">
          <Card :CardArray="cards" />
      </div>
  </div>
</template>

<script>
import Grid from './Grid.vue'
import Card from './Card.vue'

export default {
  name: 'ProductPage',
  components: {
    Grid, Card
  },
  data() {
    return {
      cards: [
      {
        id:1,
        img: 'grape.png',
        title: 'Ripe Blue Grape',
        price: 200,
        type: 'Packet',
        about: 'From the heart of the french Alps after a journey of more than 70 years, springs this Ripe Blue Grapes. Thanks to this amazing journey through the Chambotte mountains, it acquires its unique fresgqualities. With our passion for preserving this natural heritage, we are proud to offer you this moment of purity in your busy lives.',
        origin: 'France'
      },
      {
        id:2,
        img: 'salmon.png',
        title: 'Salmon',
        price: 300,
        type: 'Packet',
        about: 'This is description',
        origin: 'A'
      },
      {
        id:3,
        img: 'smallgrape.jpg',
        title: 'Small Grape',
        price: 200,
        type: 'Packet',
        about: 'This is description',
        origin: 'D'
      },
      {
        id:4,
        img: 'capsicum.png',
        title: 'Capsicum',
        price: 300,
        type: 'Packet',
        about: 'This is description',
        origin: 'B'
      },
      {
        id:5,
        img: 'tomato.png',
        title: 'Tomato',
        price: 200,
        type: 'Packet',
        about: 'This is description',
        origin: 'C'
      },
      {
        id:6,
        img: 'roseapple.png',
        title: 'Rose Apple',
        price: 150,
        type: 'Packet',
        about: 'This is description',
        origin: 'A'
      }
    ]
    }
  },
  created(){
    //this.cards = this.it
    //console.log(this.cards)
  },
  computed: {
    it(){
      return this.$store.state.items
    },
    slicedCards(){
      return this.cards.slice(0, this.showCards)
    }
  },
}
</script>

<style scoped>

.wrapper {
  display: flex;
  justify-content: space-between;
}

.divgrid{
  width: 25%;
  height: 100%;
  position: -webkit-sticky;
  position: sticky;
  top: 17%;
}

.divproduct{
  width: 75%;
}
</style>
