jest.mock('../http.js');
var functions = require('../example');

test('Adds 1 + 2 to equal 3', () => {
  expect(functions.add(1, 2)).toBe(3);
});

test('Adds 2 + 2 to not equal 5', () => {
  expect(functions.add(2, 2)).not.toBe(5);
});

test('Expect uppercase title', () => {
  functions.getTitle().then(title =>{
              expect(title).toBe('FAKE TITLE FOR TEST');
            });
});
