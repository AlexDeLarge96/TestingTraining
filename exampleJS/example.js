const {getData} = require('./http');

const example = {

  add: (a, b) => a + b,

  getTitle: () => getData('todos/1').then(json => json.title.toUpperCase())

};

module.exports = example;
