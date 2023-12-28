var lastValue = 0;
var selectedPrice = 100;
var countValue = 1;
var countValue1 = 0;
var countValue2 = 0;
var countValue3 = 0;
var countValue4 = 0;

// variables for showing cart total price:
var cartTotalAmount = 100;
var cartTotalDiscount = 10;
var cartTotalSaving = 10;
var cartTotalPaybleAmount = 90;

const incval1 = (
  commonaddvalueId,
  valueId,
  discountId,
  savingId,
  remainingId,
  countId,
  vrcountId,
  vrvalueId,
  cartTotalAmountId,
  cartTotalSavingId,
  cartTotalPaybleAmountId,
  cartCardId,
  hiddenTotalId
) => {
  document.getElementById("vrdetail1").style.display = "block";
  document.getElementById(cartCardId).style.display = "block";
  console.log("commonaddvalue: " + commonaddvalueId);
  var valueCell = document.getElementById(valueId);
  var discountCell = document.getElementById(discountId);
  var savingCell = document.getElementById(savingId);
  var remainingCell = document.getElementById(remainingId);
  var countCell = document.getElementById(countId);
  var vrcountCell = document.getElementById(vrcountId);
  var cvrvalueCell = document.getElementById(vrvalueId);
  const currentPrice = document.getElementById(valueId).innerHTML;
  const price = cvrvalueCell.innerHTML;
  //  document.getElementById(valueId).innerHTML = +currentPrice + selectedPrice
  console.log("price", price, currentPrice);
  if (countValue !== 0) {
    countValue = countValue + 1;
  } else if (commonaddvalueId !== 0) {
    countValue = countValue + 1;
  } else {
    countValue = 1;
  }

  var newValue = +price + commonaddvalueId;
  var discount = 10; // Example discount of 10%
  var remainingValue = newValue * (1 - discount / 100);
  var savingValue = newValue - remainingValue;

  if (newValue == 0) {
    discount = 0;
  }
  if (countValue === 0) {
    cvrvalueCell.innerHTML = 0;
  }

  console.log({
    newvalue: newValue,
    discount: discount,
    savingvalue: savingValue,
    remainingValue: remainingValue,
    countValue: countValue,
  });

  var element = document.getElementById("vrdetail1");

  if (countValue != 0) {
    element.hidden = false;
  } else {
    element.hidden = true;
  }

  valueCell.innerHTML = newValue;
  discountCell.innerHTML = discount;
  savingCell.innerHTML = savingValue;
  remainingCell.innerHTML = remainingValue;
  countCell.innerHTML = countValue;
  vrcountCell.innerHTML = countValue;
  cvrvalueCell.innerHTML = newValue;
  document.getElementById(hiddenTotalId).innerHTML = remainingValue;


  var cvrsavingCell = document.getElementById("cartboxsaving1");
  var cvrremainingCell = document.getElementById("cartboxremaining1");

  // cart page
  cvrsavingCell.innerHTML = savingValue;
  cvrremainingCell.innerHTML = remainingValue;

  // assigning total price to cart
  cartTotalAmount = cartTotalAmount + commonaddvalueId;
  cartTotalSaving = cartTotalSaving + discount;
  cartTotalPaybleAmount = cartTotalPaybleAmount + 90;

  // showing total amount in the Cart UI
  document.getElementById(cartTotalAmountId).innerHTML = cartTotalAmount;
  document.getElementById(cartTotalSavingId).innerHTML = cartTotalSaving;
  document.getElementById(cartTotalPaybleAmountId).innerHTML =
    cartTotalPaybleAmount;

  console.log(
    "totoal amoutn",
    cartTotalAmount,
    cartTotalSaving,
    cartTotalPaybleAmount
  );
};

const decval1 = (
  commonaddvalueId,
  valueId,
  discountId,
  savingId,
  remainingId,
  countId,
  vrcountId,
  vrvalueId,
  cartTotalAmountId,
  cartTotalSavingId,
  cartTotalPaybleAmountId,
  cartCardId,
  hiddenTotalId
) => {
  var valueCell = document.getElementById(valueId);
  var discountCell = document.getElementById(discountId);
  var savingCell = document.getElementById(savingId);
  var remainingCell = document.getElementById(remainingId);
  var countCell = document.getElementById(countId);
  var vrcountCell = document.getElementById(vrcountId);
  var cvrvalueCell = document.getElementById(vrvalueId);
  const currentPrice = document.getElementById(valueId).innerHTML;
  const price = cvrvalueCell.innerHTML;
  //  document.getElementById(valueId).innerHTML = +currentPrice + selectedPrice
  console.log("price", price, currentPrice);

  var newValue = +price - 100;
  var discount = 10; // Example discount of 10%
  var remainingValue = newValue * (1 - discount / 100);
  var savingValue = newValue - remainingValue;
  if (countValue > 0) {
    countValue--;
  } else {
    document.getElementById(cartCardId).style.display = "none";
    return;
  }
  if (newValue <= 0) {
    newValue = 0;
    discount = 0;
    remainingValue = 0;
    savingValue = 0;
    countValue = 0;
    cvrvalueCell = 0;
  }

  var element = document.getElementById("vrdetail1");

  if (countValue === 0) {
    document.getElementById("vrvalue").innerHTML = 0;
    element.hidden = true;
  } else {
    element.hidden = false;
  }

  console.log({ newValue, discount, savingValue, remainingValue, countValue });

  valueCell.innerHTML = newValue;
  discountCell.innerHTML = discount;
  savingCell.innerHTML = savingValue;
  remainingCell.innerHTML = remainingValue;
  countCell.innerHTML = countValue;
  vrcountCell.innerHTML = countValue;
  cvrvalueCell.innerHTML = newValue;
  document.getElementById(hiddenTotalId).innerHTML = remainingValue;

  
  var cvrsavingCell = document.getElementById("cartboxsaving1");
  var cvrremainingCell = document.getElementById("cartboxremaining1");

   // cart page
   cvrsavingCell.innerHTML = savingValue;
   cvrremainingCell.innerHTML = remainingValue;

  // assigning total price to cart
  cartTotalAmount =
    cartTotalAmount !== 0 ? cartTotalAmount - commonaddvalueId : 0;
  cartTotalSaving = cartTotalSaving !== 0 ? cartTotalSaving - 10 : 0;
  console.log(cartTotalSaving, discount);
  cartTotalPaybleAmount =
    cartTotalPaybleAmount !== 0 ? cartTotalPaybleAmount - 90 : 0;

  // showing total amount in the Cart UI
  document.getElementById(cartTotalAmountId).innerHTML = cartTotalAmount;
  document.getElementById(cartTotalSavingId).innerHTML = cartTotalSaving;
  document.getElementById(cartTotalPaybleAmountId).innerHTML =
    cartTotalPaybleAmount;

  console.log(
    "totoal amoutn",
    cartTotalAmount,
    cartTotalSaving,
    cartTotalPaybleAmount
  );
};

// for second

const incval2 = (
  commonaddvalueId,
  valueId,
  discountId,
  savingId,
  remainingId,
  countId,
  vrcountId,
  vrvalueId,
  cartTotalAmountId,
  cartTotalSavingId,
  cartTotalPaybleAmountId
) => {
  document.getElementById("vrdetail2").style.display = "block";

  var valueCell = document.getElementById(valueId);
  var discountCell = document.getElementById(discountId);
  var savingCell = document.getElementById(savingId);
  var remainingCell = document.getElementById(remainingId);
  var countCell = document.getElementById(countId);
  var vrcountCell = document.getElementById(vrcountId);
  var cvrvalueCell = document.getElementById(vrvalueId);
  const currentPrice = document.getElementById(valueId).innerHTML;
  //  document.getElementById(valueId).innerHTML = +currentPrice + selectedPrice
  const price = cvrvalueCell.innerHTML;
  // if(countValue1 === 0){
  //  price = 0;
  // }
  console.log("price", price, currentPrice);
  //  document.getElementById(valueId).innerHTML = +currentPrice + selectedPrice
  if (countValue1 !== 0) {
    countValue1 = countValue1 + 1;
  } else if (commonaddvalueId !== 0) {
    countValue1 = countValue1 + 1;
  } else {
    countValue1 = 1;
  }

  var newValue = +price + commonaddvalueId;
  var discount = 10; // Example discount of 10%
  var remainingValue = newValue * (1 - discount / 100);
  var savingValue = newValue - remainingValue;

  if (newValue == 0) {
    discount = 0;
  }
  console.log({ newValue, discount, savingValue, remainingValue, countValue });

  var element = document.getElementById("vrdetail2");

  if (countValue1 === 0) {
    element.hidden = true;
  } else {
    element.hidden = false;
  }

  valueCell.innerHTML = newValue;
  discountCell.innerHTML = discount;
  savingCell.innerHTML = savingValue;
  remainingCell.innerHTML = remainingValue;
  countCell.innerHTML = countValue1;
  vrcountCell.innerHTML = countValue1;
  cvrvalueCell.innerHTML = newValue;

  
  var cvrsavingCell = document.getElementById("cartboxsaving2");
  var cvrremainingCell = document.getElementById("cartboxremaining2");

   // cart page
   cvrsavingCell.innerHTML = savingValue;
   cvrremainingCell.innerHTML = remainingValue;

  console.log("before assign", {
    cartTotalAmount,
    cartTotalSaving,
    cartTotalPaybleAmount,
  });
  // assigning total price to cart
  cartTotalAmount = cartTotalAmount + commonaddvalueId;
  cartTotalSaving = cartTotalSaving + 20;
  cartTotalPaybleAmount = cartTotalPaybleAmount + 180;

  // showing total amount in the Cart UI
  document.getElementById(cartTotalAmountId).innerHTML = cartTotalAmount;
  document.getElementById(cartTotalSavingId).innerHTML = cartTotalSaving;
  document.getElementById(cartTotalPaybleAmountId).innerHTML =
    cartTotalPaybleAmount;

  console.log(
    "totoal amoutn",
    cartTotalAmount,
    cartTotalSaving,
    cartTotalPaybleAmount
  );
};

const decval2 = (
  commonaddvalueId,
  valueId,
  discountId,
  savingId,
  remainingId,
  countId,
  vrcountId,
  vrvalueId,
  cartTotalAmountId,
  cartTotalSavingId,
  cartTotalPaybleAmountId
) => {
  var valueCell = document.getElementById(valueId);
  var discountCell = document.getElementById(discountId);
  var savingCell = document.getElementById(savingId);
  var remainingCell = document.getElementById(remainingId);
  var countCell = document.getElementById(countId);
  var vrcountCell = document.getElementById(vrcountId);
  var cvrvalueCell = document.getElementById(vrvalueId);
  const currentPrice = document.getElementById(valueId).innerHTML;

  const price = cvrvalueCell.innerHTML;
  console.log("price", price, currentPrice);

  var newValue = +price - commonaddvalueId;
  var discount = 10; // Example discount of 10%
  var remainingValue = newValue * (1 - discount / 100);
  var savingValue = newValue - remainingValue;

  if (countValue1 > 0) {
    countValue1--;
  } else {
    return;
  }

  if (newValue <= 0) {
    newValue = 0;
    discount = 0;
    remainingValue = 0;
    savingValue = 0;
    countValue1 = 0;
  }
  var element = document.getElementById("vrdetail2");

  if (countValue1 === 0) {
    element.hidden = true;
  } else {
    element.hidden = false;
  }

  valueCell.innerHTML = newValue;
  discountCell.innerHTML = discount;
  savingCell.innerHTML = savingValue;
  remainingCell.innerHTML = remainingValue;
  countCell.innerHTML = countValue1;
  vrcountCell.innerHTML = countValue1;
  cvrvalueCell.innerHTML = newValue;
 
  var cvrsavingCell = document.getElementById("cartboxsaving2");
  var cvrremainingCell = document.getElementById("cartboxremaining2");

   // cart page
   cvrsavingCell.innerHTML = savingValue;
   cvrremainingCell.innerHTML = remainingValue;

  console.log(discount, "dis");
  // assigning total price to cart
  cartTotalAmount =
    cartTotalAmount !== 0 ? cartTotalAmount - commonaddvalueId : 0;
  cartTotalSaving = cartTotalSaving !== 0 ? cartTotalSaving - 20 : 0;
  console.log(cartTotalSaving, discount);
  cartTotalPaybleAmount =
    cartTotalPaybleAmount !== 0 ? cartTotalPaybleAmount - 180 : 0;

  // showing total amount in the Cart UI
  document.getElementById(cartTotalAmountId).innerHTML = cartTotalAmount;
  document.getElementById(cartTotalSavingId).innerHTML = cartTotalSaving;
  document.getElementById(cartTotalPaybleAmountId).innerHTML =
    cartTotalPaybleAmount;

  console.log(
    "totoal amoutn",
    cartTotalAmount,
    cartTotalSaving,
    cartTotalPaybleAmount
  );
};

// for third

const incval3 = (
  commonaddvalueId,
  valueId,
  discountId,
  savingId,
  remainingId,
  countId,
  vrcountId,
  vrvalueId,
  cartTotalAmountId,
  cartTotalSavingId,
  cartTotalPaybleAmountId
) => {
  document.getElementById("vrdetail3").style.display = "block";

  var valueCell = document.getElementById(valueId);
  var discountCell = document.getElementById(discountId);
  var savingCell = document.getElementById(savingId);
  var remainingCell = document.getElementById(remainingId);
  var countCell = document.getElementById(countId);
  var vrcountCell = document.getElementById(vrcountId);
  var cvrvalueCell = document.getElementById(vrvalueId);
  const currentPrice = document.getElementById(valueId).innerHTML;
  //  document.getElementById(valueId).innerHTML = +currentPrice + selectedPrice
  const price = cvrvalueCell.innerHTML;
  console.log("commonaddvalueId", commonaddvalueId);
  console.log("price", price, currentPrice);

  if (countValue2 !== 0) {
    countValue2 = countValue2 + 1;
  } else if (commonaddvalueId !== 0) {
    countValue2 = countValue2 + 1;
  } else {
    countValue2 = 1;
  }

  var newValue = +price + commonaddvalueId;
  console.log("newValue", newValue);
  var discount = 10; // Example discount of 10%
  var remainingValue = newValue * (1 - discount / 100);
  console.log("remainingValue", remainingValue);
  var savingValue = newValue - remainingValue;

  if (newValue == 0) {
    discount = 0;
  }
  const element = document.getElementById("vrdetail3");

  if (countValue2 === 0) {
    element.hidden = true;
  } else {
    element.hidden = false;
  }

  valueCell.innerHTML = newValue;
  discountCell.innerHTML = discount;
  savingCell.innerHTML = savingValue;
  remainingCell.innerHTML = remainingValue;
  countCell.innerHTML = countValue2;
  vrcountCell.innerHTML = countValue2;
  cvrvalueCell.innerHTML = newValue;
   
  var cvrsavingCell = document.getElementById("cartboxsaving3");
  var cvrremainingCell = document.getElementById("cartboxremaining3");

   // cart page
   cvrsavingCell.innerHTML = savingValue;
   cvrremainingCell.innerHTML = remainingValue;


  // assigning total price to cart
  cartTotalAmount = cartTotalAmount + commonaddvalueId;
  cartTotalSaving = cartTotalSaving + 50;
  cartTotalPaybleAmount = cartTotalPaybleAmount + 450;

  // showing total amount in the Cart UI
  document.getElementById(cartTotalAmountId).innerHTML = cartTotalAmount;
  document.getElementById(cartTotalSavingId).innerHTML = cartTotalSaving;
  document.getElementById(cartTotalPaybleAmountId).innerHTML =
    cartTotalPaybleAmount;

  console.log(
    "totoal amoutn 3",
    cartTotalAmount,
    cartTotalSaving,
    cartTotalPaybleAmount
  );
};

const decval3 = (
  commonaddvalueId,
  valueId,
  discountId,
  savingId,
  remainingId,
  countId,
  vrcountId,
  vrvalueId,
  cartTotalAmountId,
  cartTotalSavingId,
  cartTotalPaybleAmountId
) => {
  var valueCell = document.getElementById(valueId);
  var discountCell = document.getElementById(discountId);
  var savingCell = document.getElementById(savingId);
  var remainingCell = document.getElementById(remainingId);
  var countCell = document.getElementById(countId);
  var vrcountCell = document.getElementById(vrcountId);
  var cvrvalueCell = document.getElementById(vrvalueId);
  const currentPrice = document.getElementById(valueId).innerHTML;

  const price = cvrvalueCell.innerHTML;
  console.log("price 3", price, currentPrice);

  var newValue = +price - commonaddvalueId;
  var discount = 10; // Example discount of 10%
  var remainingValue = newValue * (1 - discount / 100);
  var savingValue = newValue - remainingValue;

  if (countValue2 > 0) {
    countValue2--;
  } else {
    return;
  }
  if (newValue <= 0) {
    newValue = 0;
    discount = 0;
    remainingValue = 0;
    savingValue = 0;
    countValue2 = 0;
  }

  const element = document.getElementById("vrdetail3");

  if (countValue2 === 0) {
    element.hidden = true;
  } else {
    element.hidden = false;
  }

  valueCell.innerHTML = newValue;
  discountCell.innerHTML = discount;
  savingCell.innerHTML = savingValue;
  remainingCell.innerHTML = remainingValue;
  countCell.innerHTML = countValue2;
  vrcountCell.innerHTML = countValue2;
  cvrvalueCell.innerHTML = newValue;

  var cvrsavingCell = document.getElementById("cartboxsaving3");
  var cvrremainingCell = document.getElementById("cartboxremaining3");

   // cart page
   cvrsavingCell.innerHTML = savingValue;
   cvrremainingCell.innerHTML = remainingValue;


  console.log("discount", discount);

  // assigning total price to cart
  cartTotalAmount =
    cartTotalAmount !== 0 ? cartTotalAmount - commonaddvalueId : 0;
  cartTotalSaving = cartTotalSaving !== 0 ? cartTotalSaving - 50 : 0;
  console.log(cartTotalSaving, discount);
  cartTotalPaybleAmount =
    cartTotalPaybleAmount !== 0 ? cartTotalPaybleAmount - 450 : 0;

  // showing total amount in the Cart UI
  document.getElementById(cartTotalAmountId).innerHTML = cartTotalAmount;
  document.getElementById(cartTotalSavingId).innerHTML = cartTotalSaving;
  document.getElementById(cartTotalPaybleAmountId).innerHTML =
    cartTotalPaybleAmount;

  console.log(
    "totoal amoutn",
    cartTotalAmount,
    cartTotalSaving,
    cartTotalPaybleAmount
  );
};

// for fourth

const incval4 = (
  commonaddvalueId,
  valueId,
  discountId,
  savingId,
  remainingId,
  countId,
  vrcountId,
  vrvalueId,
  cartTotalAmountId,
  cartTotalSavingId,
  cartTotalPaybleAmountId
) => {
  document.getElementById("vrdetail4").style.display = "block";

  var valueCell = document.getElementById(valueId);
  var discountCell = document.getElementById(discountId);
  var savingCell = document.getElementById(savingId);
  var remainingCell = document.getElementById(remainingId);
  var countCell = document.getElementById(countId);
  var vrcountCell = document.getElementById(vrcountId);
  var cvrvalueCell = document.getElementById(vrvalueId);
  const currentPrice = document.getElementById(valueId).innerHTML;
  //  document.getElementById(valueId).innerHTML = +currentPrice + selectedPrice

  const price = cvrvalueCell.innerHTML;
  console.log("price", price, currentPrice);

  if (countValue3 !== 0) {
    countValue3 = countValue3 + 1;
  } else if (commonaddvalueId !== 0) {
    countValue3 = countValue3 + 1;
  } else {
    countValue3 = 1;
  }

  var newValue = +price + commonaddvalueId;
  var discount = 10; // Example discount of 10%
  var remainingValue = newValue * (1 - discount / 100);
  var savingValue = newValue - remainingValue;

  if (newValue == 0) {
    discount = 0;
  }

  const element = document.getElementById("vrdetail4");

  if (countValue3 === 0) {
    element.hidden = true;
  } else {
    element.hidden = false;
  }

  valueCell.innerHTML = newValue;
  discountCell.innerHTML = discount;
  savingCell.innerHTML = savingValue;
  remainingCell.innerHTML = remainingValue;
  countCell.innerHTML = countValue3;
  vrcountCell.innerHTML = countValue3;
  cvrvalueCell.innerHTML = newValue;

  var cvrsavingCell = document.getElementById("cartboxsaving4");
  var cvrremainingCell = document.getElementById("cartboxremaining4");

   // cart page
   cvrsavingCell.innerHTML = savingValue;
   cvrremainingCell.innerHTML = remainingValue;


  // assigning total price to cart
  cartTotalAmount = cartTotalAmount + commonaddvalueId;
  cartTotalSaving = cartTotalSaving + 100;
  cartTotalPaybleAmount = cartTotalPaybleAmount + 900;

  // showing total amount in the Cart UI
  document.getElementById(cartTotalAmountId).innerHTML = cartTotalAmount;
  document.getElementById(cartTotalSavingId).innerHTML = cartTotalSaving;
  document.getElementById(cartTotalPaybleAmountId).innerHTML =
    cartTotalPaybleAmount;

  console.log(
    "totoal amoutn 3",
    cartTotalAmount,
    cartTotalSaving,
    cartTotalPaybleAmount
  );
};

const decval4 = (
  commonaddvalueId,
  valueId,
  discountId,
  savingId,
  remainingId,
  countId,
  vrcountId,
  vrvalueId,
  cartTotalAmountId,
  cartTotalSavingId,
  cartTotalPaybleAmountId
) => {
  var valueCell = document.getElementById(valueId);
  var discountCell = document.getElementById(discountId);
  var savingCell = document.getElementById(savingId);
  var remainingCell = document.getElementById(remainingId);
  var countCell = document.getElementById(countId);
  var vrcountCell = document.getElementById(vrcountId);
  var cvrvalueCell = document.getElementById(vrvalueId);
  const currentPrice = document.getElementById(valueId).innerHTML;

  const price = cvrvalueCell.innerHTML;
  console.log("price4", price, currentPrice);

  var newValue = +price - commonaddvalueId;
  var discount = 10; // Example discount of 10%
  var remainingValue = newValue * (1 - discount / 100);
  var savingValue = newValue - remainingValue;

  if (countValue3 > 0) {
    countValue3--;
  } else {
    return;
  }

  if (newValue <= 0) {
    newValue = 0;
    discount = 0;
    remainingValue = 0;
    savingValue = 0;
    countValue3 = 0;
  }

  const element = document.getElementById("vrdetail4");

  if (countValue3 === 0) {
    element.hidden = true;
  } else {
    element.hidden = false;
  }

  valueCell.innerHTML = newValue;
  discountCell.innerHTML = discount;
  savingCell.innerHTML = savingValue;
  remainingCell.innerHTML = remainingValue;
  countCell.innerHTML = countValue3;
  vrcountCell.innerHTML = countValue3;
  cvrvalueCell.innerHTML = newValue;
  
  var cvrsavingCell = document.getElementById("cartboxsaving4");
  var cvrremainingCell = document.getElementById("cartboxremaining4");

   // cart page
   cvrsavingCell.innerHTML = savingValue;
   cvrremainingCell.innerHTML = remainingValue;


  // assigning total price to cart
  cartTotalAmount =
    cartTotalAmount !== 0 ? cartTotalAmount - commonaddvalueId : 0;
  cartTotalSaving = cartTotalSaving !== 0 ? cartTotalSaving - 100 : 0;
  console.log(cartTotalSaving, discount);
  cartTotalPaybleAmount =
    cartTotalPaybleAmount !== 0 ? cartTotalPaybleAmount - 900 : 0;

  // showing total amount in the Cart UI
  document.getElementById(cartTotalAmountId).innerHTML = cartTotalAmount;
  document.getElementById(cartTotalSavingId).innerHTML = cartTotalSaving;
  document.getElementById(cartTotalPaybleAmountId).innerHTML =
    cartTotalPaybleAmount;

  console.log(
    "totoal amoutn",
    cartTotalAmount,
    cartTotalSaving,
    cartTotalPaybleAmount
  );
};

// for fifth

const incval5 = (
  commonaddvalueId,
  valueId,
  discountId,
  savingId,
  remainingId,
  countId,
  vrcountId,
  vrvalueId,
  cartTotalAmountId,
  cartTotalSavingId,
  cartTotalPaybleAmountId
) => {
  document.getElementById("vrdetail5").style.display = "block";

  var valueCell = document.getElementById(valueId);
  var discountCell = document.getElementById(discountId);
  var savingCell = document.getElementById(savingId);
  var remainingCell = document.getElementById(remainingId);
  var countCell = document.getElementById(countId);
  var vrcountCell = document.getElementById(vrcountId);
  var cvrvalueCell = document.getElementById(vrvalueId);
  const currentPrice = document.getElementById(valueId).innerHTML;
  //  document.getElementById(valueId).innerHTML = +currentPrice + selectedPrice

  const price = cvrvalueCell.innerHTML;
  console.log("price 5", price, currentPrice);

  if (countValue4 !== 0) {
    countValue4 = countValue4 + 1;
  } else if (commonaddvalueId !== 0) {
    countValue4 = countValue4 + 1;
  } else {
    countValue4 = 1;
  }

  var newValue = +price + commonaddvalueId;
  var discount = 10; // Example discount of 10%
  var remainingValue = newValue * (1 - discount / 100);
  var savingValue = newValue - remainingValue;

  if (newValue == 0) {
    discount = 0;
  }

  const element = document.getElementById("vrdetail5");

  if (countValue4 === 0) {
    element.hidden = true;
  } else {
    element.hidden = false;
  }

  valueCell.innerHTML = newValue;
  discountCell.innerHTML = discount;
  savingCell.innerHTML = savingValue;
  remainingCell.innerHTML = remainingValue;
  countCell.innerHTML = countValue4;
  vrcountCell.innerHTML = countValue4;
  cvrvalueCell.innerHTML = newValue;

  
  var cvrsavingCell = document.getElementById("cartboxsaving5");
  var cvrremainingCell = document.getElementById("cartboxremaining5");

   // cart page
   cvrsavingCell.innerHTML = savingValue;
   cvrremainingCell.innerHTML = remainingValue;


  // assigning total price to cart
  cartTotalAmount = cartTotalAmount + commonaddvalueId;
  cartTotalSaving = cartTotalSaving + 200;
  cartTotalPaybleAmount = cartTotalPaybleAmount + 1800;

  // showing total amount in the Cart UI
  document.getElementById(cartTotalAmountId).innerHTML = cartTotalAmount;
  document.getElementById(cartTotalSavingId).innerHTML = cartTotalSaving;
  document.getElementById(cartTotalPaybleAmountId).innerHTML =
    cartTotalPaybleAmount;

  console.log(
    "totoal amoutn 3",
    cartTotalAmount,
    cartTotalSaving,
    cartTotalPaybleAmount
  );
};

const decval5 = (
  commonaddvalueId,
  valueId,
  discountId,
  savingId,
  remainingId,
  countId,
  vrcountId,
  vrvalueId,
  cartTotalAmountId,
  cartTotalSavingId,
  cartTotalPaybleAmountId
) => {
  var valueCell = document.getElementById(valueId);
  var discountCell = document.getElementById(discountId);
  var savingCell = document.getElementById(savingId);
  var remainingCell = document.getElementById(remainingId);
  var countCell = document.getElementById(countId);
  var vrcountCell = document.getElementById(vrcountId);
  var cvrvalueCell = document.getElementById(vrvalueId);
  const currentPrice = document.getElementById(valueId).innerHTML;

  const price = cvrvalueCell.innerHTML;
  console.log("price", price, currentPrice);

  var newValue = +price - commonaddvalueId;
  var discount = 10; // Example discount of 10%
  var remainingValue = newValue * (1 - discount / 100);
  var savingValue = newValue - remainingValue;

  if (countValue4 > 0) {
    countValue4--;
  } else {
    return;
  }

  if (newValue <= 0) {
    newValue = 0;
    discount = 0;
    remainingValue = 0;
    savingValue = 0;
    countValue4 = 0;
  }

  const element = document.getElementById("vrdetail5");

  if (countValue4 === 0) {
    element.hidden = true;
  } else {
    element.hidden = false;
  }

  valueCell.innerHTML = newValue;
  discountCell.innerHTML = discount;
  savingCell.innerHTML = savingValue;
  remainingCell.innerHTML = remainingValue;
  countCell.innerHTML = countValue4;
  vrcountCell.innerHTML = countValue4;
  cvrvalueCell.innerHTML = newValue;
    
  var cvrsavingCell = document.getElementById("cartboxsaving5");
  var cvrremainingCell = document.getElementById("cartboxremaining5");

   // cart page
   cvrsavingCell.innerHTML = savingValue;
   cvrremainingCell.innerHTML = remainingValue;


  console.log("discount", discount);

  // assigning total price to cart
  cartTotalAmount =
    cartTotalAmount !== 0 ? cartTotalAmount - commonaddvalueId : 0;
  cartTotalSaving = cartTotalSaving !== 0 ? cartTotalSaving - 200 : 0;
  console.log(cartTotalSaving, discount);
  cartTotalPaybleAmount =
    cartTotalPaybleAmount !== 0 ? cartTotalPaybleAmount - 1800 : 0;

  // showing total amount in the Cart UI
  document.getElementById(cartTotalAmountId).innerHTML = cartTotalAmount;
  document.getElementById(cartTotalSavingId).innerHTML = cartTotalSaving;
  document.getElementById(cartTotalPaybleAmountId).innerHTML =
    cartTotalPaybleAmount;

  console.log(
    "totoal amoutn",
    cartTotalAmount,
    cartTotalSaving,
    cartTotalPaybleAmount
  );
};

function addtotalvalue() {}

function removeCard(id, vrvalue, hiddenTotalId, countId) {
  console.log("deleted");
  document.getElementById(id).style.display = "none";

  const totalAmountCell = document.getElementById("tvalue");
  const savingAmountCell = document.getElementById("svalue");
  const paybleAmountCell = document.getElementById("pvalue");

  // totalAmount details
  const totalAmount = +totalAmountCell.innerHTML;
  const savingAmount = +savingAmountCell.innerHTML;
  const paybleAmount = +paybleAmountCell.innerHTML;

  console.log({ totalAmount, savingAmount, paybleAmount });

  // individual card amount
  const cardTotalAmount = +document.getElementById(vrvalue).innerHTML;
  const discounts = 10;
  const cardPaybleAmount = +cardTotalAmount * (1 - discounts / 100);
  const cardSavingAmount = +cardTotalAmount - +cardPaybleAmount;
  console.log({ cardTotalAmount, cardPaybleAmount, cardSavingAmount });

  // now we are showing the totalAmount after deleting the cardAmount
  totalAmountCell.innerHTML = totalAmount - cardTotalAmount;
  savingAmountCell.innerHTML = savingAmount - cardSavingAmount;
  paybleAmountCell.innerHTML = paybleAmount - cardPaybleAmount;

  //manipulating the global totalAmount
  cartTotalAmount = totalAmount - cardTotalAmount;
  cartTotalDiscount = cardTotalAmount - cardPaybleAmount;
  cartTotalSaving = savingAmount - cardSavingAmount;
  cartTotalPaybleAmount = paybleAmount - cardPaybleAmount;

  var countCell = document.getElementById(countId);
  console.log(countCell);
  switch (countId) {
    case "count":
      {
        countValue = 0;
        console.log("count 1");
        document.getElementById("value").innerHTML = 0;
        document.getElementById("discount").innerHTML = 0;
        document.getElementById("saving").innerHTML = 0;
        document.getElementById("remaining").innerHTML = 0;
        document.getElementById("vrvalue").innerHTML = 0;
        console.log("all deleted");
      }
      break;
    case "count1":
      {
        countValue1 = 0;
        console.log("count 2");
        document.getElementById("value").innerHTML = 0;
        document.getElementById("discount").innerHTML = 0;
        document.getElementById("saving").innerHTML = 0;
        document.getElementById("remaining").innerHTML = 0;
        document.getElementById("vrvalue1").innerHTML = 0;
      }
      break;
    case "count2":
      {
        countValue2 = 0;
        document.getElementById("value").innerHTML = 0;
        document.getElementById("discount").innerHTML = 0;
        document.getElementById("saving").innerHTML = 0;
        document.getElementById("remaining").innerHTML = 0;
        document.getElementById("vrvalue2").innerHTML = 0;
      }
      break;
    case "count3":
      {
        countValue3 = 0;
        document.getElementById("value").innerHTML = 0;
        document.getElementById("discount").innerHTML = 0;
        document.getElementById("saving").innerHTML = 0;
        document.getElementById("remaining").innerHTML = 0;
        document.getElementById("vrvalue3").innerHTML = 0;
      }
      break;
    case "count4":
      {
        countValue4 = 0;
        document.getElementById("value").innerHTML = 0;
        document.getElementById("discount").innerHTML = 0;
        document.getElementById("saving").innerHTML = 0;
        document.getElementById("remaining").innerHTML = 0;
        document.getElementById("vrvalue4").innerHTML = 0;
      }
      break;
  }

  if (countCell != 0) {
    countCell.innerHTML = 0;
    countValue.innerHTML = countCell;
    countValue1.innerHTML = countCell;
    countValue2.innerHTML = countCell;
    countValue3.innerHTML = countCell;
    countValue4.innerHTML = countCell;
    console.log(countValue2);
  }
}
