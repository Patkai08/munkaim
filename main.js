let fruits = ["alma", "korte", "barack", "szolo", "narancs"];

let dataContainer = document.getElementById("asd");
/**
 * List creator
 * @param {*} data
 * @param {*} container
 * @param {*} type
 */
const createList = (data, container, type) => {
  let list = document.createElement(type);
  for (const element of data) {
    createListItem(element, list);
  }
  container.append(list);
};
/**
 * ordered list creator
 * @param {fruits} element
 * @param {ordered} list
 */
const createListItem = (element, list) => {
  let li = document.createElement("li");
  li.innerText = element;
  list.append(li);
};
createList(fruits, dataContainer, "ol");
let index = 0;

while (index < fruits.length && !(fruits[index] === "banan")) {
  index++;
}

let p = document.createElement("p");
if (index < fruits.length) {
  p.innerText = "Van banán";
  dataContainer.append(p);
} else {
  p.innerText = "Nincs banán";
  dataContainer.append(p);
}

/*
const checkValue = (value, array) =>{
  let index = 0;
  while
}
 
let p = document.createElement("p");
if (index < fruits.length) {
  p.innerText = "Van banán";
  dataContainer.append(p);
} else {
  p.innerText = "Nincs banán";
  dataContainer.append(p);
}
*/

const createLList = (data, container) => {
  let list = document.createElement("ul");
  for (const element of numberArray) {
    createListItem(element, numberArray);
  }
  container.append(list);
};
let numberArray = [];
/**
 *  unordered number list creator with numbers from 8-8000
 * @param {number} min
 * @param {number} max
 * @returns
 */
const rnd = (min, max) => {
  return Math.floor(Math.random() * (max - min + 1) + min);
};

for (let i = 0; i < 400; i++) {
  numberArray.push(rnd(8, 8000));
}
console.log(numberArray);

createList(numberArray, dataContainer, "ul");
