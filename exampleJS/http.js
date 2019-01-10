const axios = require('axios');

const base_url= 'https://jsonplaceholder.typicode.com/';

const getData = (path) => {
  return axios
          .get(base_url+path)
          .then(response => response.data);
};

exports.getData = getData;
