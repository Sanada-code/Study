new Vue({
  el: "#app",
  data: {
    lists: [
      {
        name: "item1",
        checked: false,
      },
      {
        name: "item2",
        checked: true,
      },
      {
        name: "item3",
        checked: false,
      },
    ],
    newItem: "",
  },

  methods: {
    AddItem: function (event) {
      if (this.newItem == "") {
        return;
      }
      let item = {
        name: this.newItem,
        checked: false,
      };
      this.lists.push(item);
      this.newItem = "";
    },
    DelItem: function (index) {
      this.lists.splice(index, 1);
    },
  },
});
