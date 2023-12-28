$(document).ready(function(){

  $('#digitaltmn').owlCarousel({
    loop: true,
    autoplayHoverPause:true,
    center: false,
    margin: 30,
    dots: false,
    nav: true,
    navContainerClass: "packslide-nav",
        // navText: ['<img src="https://cdn3.iconfinder.com/data/icons/faticons/32/arrow-left-01-512.png">', '<img src="https://tse1.mm.bing.net/th?id=OIP.mfJUwhIy4z5hhuX4dMiYQQHaHa&pid=Api&P=0">'],
        // navClass: ["navarrowbtnprev", "navarrowbtnnext"],
    autoplay: true,
    autoplayTimeout: 3000,
    smartSpeed: 2000,
    responsive: {
        0: {
            items: 1,
            center: true,
            nav: false,
        },
        600: {
            items: 1.6,
            center: true,
            nav: false,
        },
        768: {
            items: 2,
            margin: 20,
        },
        1200: {
            items: 3
        }
    }
});

    $('#owlFamily,#owlFamily1,#owlFamily2').owlCarousel({
        loop: true,
        autoplayHoverPause: true,
        center: false,
        margin: 10,
        dots: false,
        nav: true,
        navContainerClass: "packslide-nav",
        // navText: ['<img src="https://cdn3.iconfinder.com/data/icons/faticons/32/arrow-left-01-512.png">', '<img src="https://tse1.mm.bing.net/th?id=OIP.mfJUwhIy4z5hhuX4dMiYQQHaHa&pid=Api&P=0">'],
        // navClass: ["navarrowbtnprev", "navarrowbtnnext"],
        autoplay: true,
        autoplayTimeout: 3000,
        smartSpeed: 2000,
        responsive: {
            0: {
                items: 1,
                center: true,
                nav: false,
            },
            600: {
                items: 1.6,
                center: true,
                nav: false,
            },
            768: {
                items: 3
            },
            1200: {
                items: 4
            }
        }
    });


    $('#owlshop').owlCarousel({
        loop: true,
        center: false,
        margin: 10,
        dots: false,
        nav: true,
        navContainerClass: "packslide-nav",
            // navText: ['<img src="https://cdn3.iconfinder.com/data/icons/faticons/32/arrow-left-01-512.png">', '<img src="https://tse1.mm.bing.net/th?id=OIP.mfJUwhIy4z5hhuX4dMiYQQHaHa&pid=Api&P=0">'],
            // navClass: ["navarrowbtnprev", "navarrowbtnnext"],
        autoplay: false,
        autoplayTimeout: 3000,
        smartSpeed: 2000,
        responsive: {
            0: {
                items: 2,
            },
            600: {
                items: 3,
            },
            768: {
                items: 4
            },
            1200: {
                items: 6
            }
        }
    });



});

var lastValue = 0;
var selectedPrice = 100;
var countValue = 1;

const voucherprice = (commonId, valueId, discountId, savingId, remainingId, countId) => {

    $('#DenominationOrg').val(commonId);

  var valueCell = document.getElementById(valueId);
  var discountCell = document.getElementById(discountId);
  var savingCell = document.getElementById(savingId);
  var remainingCell = document.getElementById(remainingId);
  var countCell = document.getElementById(countId);

  selectedPrice = commonId;
  // var currentValue = parseInt(valueCell.innerHTML);
  // var newValue = currentValue + 100;  
    //var discount = 10; // Example discount of 10%        
    var discount = discountCell.innerHTML; // Example discount of 10%        
  var remainingValue = commonId * (1 - discount / 100);
  var savingValue = commonId - remainingValue;

  if(countValue === 0 ){
    countValue++;
  }else{
    countValue = 1;
  }
  
  if (commonId !== lastValue) {
        valueCell.innerHTML = commonId;
        discountCell.innerHTML = discount;
        savingCell.innerHTML = savingValue;
        remainingCell.innerHTML = remainingValue;
        countCell.innerHTML = countValue;
      }

}


const incval1 = (
    commonaddvalueId,
    valueId,
    discountId,
    savingId,
    remainingId,
    countId
) => {
    document.getElementById("vrdetail1").style.display = "block";
    //document.getElementById(cartCardId).style.display = "block";
    console.log("commonaddvalue: " + commonaddvalueId);
    var valueCell = document.getElementById(valueId);
    var discountCell = document.getElementById(discountId);
    var savingCell = document.getElementById(savingId);
    var remainingCell = document.getElementById(remainingId);
    var countCell = document.getElementById(countId);
    
    const currentPrice = document.getElementById(valueId).innerHTML;
  
    //  document.getElementById(valueId).innerHTML = +currentPrice + selectedPrice
 
    if (countValue !== 0) {
        countValue = countValue + 1;
    } else if (commonaddvalueId !== 0) {
        countValue = countValue + 1;
    } else {
        countValue = 1;
    }

    var newValue = 0;
    var discount = 10; // Example discount of 10%
    var remainingValue = newValue * (1 - discount / 100);
    var savingValue = newValue - remainingValue;

    if (newValue == 0) {
        discount = 0;
    }
    

   

    

    valueCell.innerHTML = newValue;
    discountCell.innerHTML = discount;
    savingCell.innerHTML = savingValue;
    remainingCell.innerHTML = remainingValue;
    countCell.innerHTML = countValue;
  


 

    // cart page
   

    // assigning total price to cart
  

    // showing total amount in the Cart UI
   
  
};


  const decval1 = (valueId, discountId, savingId, remainingId, countId) => {
    var valueCell = document.getElementById(valueId);
    var discountCell = document.getElementById(discountId);
    var savingCell = document.getElementById(savingId);
    var remainingCell = document.getElementById(remainingId);
    var countCell = document.getElementById(countId);
    const currentPrice = document.getElementById(valueId).innerHTML;

      var newValue = +currentPrice - selectedPrice;
      var discount = discountCell.innerHTML;; // Example discount of 10%        
      var remainingValue = newValue * (1 - discount / 100);
      var savingValue = newValue - remainingValue;
  
          if (countValue > 0) {
              countValue--;
            }
            if(newValue <= 0){
              newValue = 0;
              discount = 0;
              remainingValue = 0;
              savingValue = 0;
              countValue = 0;
            }

  
      valueCell.innerHTML = newValue;
      discountCell.innerHTML = discount;
      savingCell.innerHTML = savingValue;
      remainingCell.innerHTML = remainingValue;
      countCell.innerHTML = countValue;
    }

  const addValues = (valueId, discountId, savingId, remainingId, countId, tvalueId, svalueId, pvalueId, tcountId, tvoucherId) =>{
    var valueCell = document.getElementById(valueId).innerText;
    var savingCell = document.getElementById(savingId).innerText;
    var remainingCell = document.getElementById(remainingId).innerText;
    var countCell = document.getElementById(countId).innerText;

    var tvalues = document.getElementById(tvalueId);
    tvalues.innerText = +valueCell

    var svalues = document.getElementById(svalueId);
    svalues.innerText = +savingCell

    var pvalues = document.getElementById(pvalueId);
    pvalues.innerText = +remainingCell

    var cvalues = document.getElementById(tcountId);
    cvalues.innerText = +countCell

    var vvalues = document.getElementById(tvoucherId);
    vvalues.innerText = +selectedPrice || 100

    var element = document.getElementById("tcountpara");

    if(countCell >= 1){
      element.hidden = false;
    }
    // if (countCell === 0) {
    //   element.style.display = "none";
    // } else {
    //   element.style.display = "block"; // or any other desired display value
    // }
  

  }


      function resetValues() {
        var valueCells = document.querySelectorAll('span[id^="value"]');
        var discountCells = document.querySelectorAll('span[id^="discount"]');
        var remainingCells = document.querySelectorAll('span[id^="remaining"]');
        var savingCells = document.querySelectorAll('span[id^="saving"]');
        var countCells = document.querySelectorAll('span[id^="count"]');

        var tcountCells = document.querySelectorAll('span[id^="tcount"]');
        var tvoucherCells = document.querySelectorAll('span[id^="tvoucher"]');
        var tvalueCells = document.querySelectorAll('span[id^="tvalue"]');
        var tremainingCells = document.querySelectorAll('span[id^="pvalue"]');
        var tsavingCells = document.querySelectorAll('span[id^="svalue"]');
      
        valueCells.forEach(cell => {
          cell.innerHTML = 0;
        });
      
        discountCells.forEach(cell => {
          cell.innerHTML = 0;
        });
      
        remainingCells.forEach(cell => {
          cell.innerHTML = "0";
        });
      
        savingCells.forEach(cell => {
          cell.innerHTML = "0";
        });
        
        countCells.forEach(cell => {
            cell.innerHTML = "0";
          });

          tcountCells.forEach(cell => {
            cell.innerHTML = "0";
          });

          tvoucherCells.forEach(cell => {
            cell.innerHTML = "0";
          });

          tvalueCells.forEach(cell => {
            cell.innerHTML = "0";
          });

          tremainingCells.forEach(cell => {
            cell.innerHTML = "0";
          });

          tsavingCells.forEach(cell => {
            cell.innerHTML = "0";
          });

        countValue=0;   

        var element = document.getElementById("tcountpara");

        element.hidden = true;
        // if (countValue === 0) {
        //   element.style.display = "none";
        // } else {
        //   element.style.display = "block"; // or any other desired display value
        // }
      

      }

      var navLinks = document.querySelectorAll('.pricing_sec');

// Loop through the links and add event listeners
navLinks.forEach(function(link) {
  link.addEventListener('click', function() {
    // Remove the 'active' class from all links
    navLinks.forEach(function(link) {
      link.classList.remove('active');
    });

    // Add the 'active' class to the clicked link
    this.classList.add('active');
  });
});

// insurance start 

const accordionItemHeaders = document.querySelectorAll(".accordion-item-header");

accordionItemHeaders.forEach(accordionItemHeader => {
  accordionItemHeader.addEventListener("click", event => {

    accordionItemHeader.classList.toggle("active");
    const accordionItemBody = accordionItemHeader.nextElementSibling;
    if(accordionItemHeader.classList.contains("active")) {
      accordionItemBody.style.maxHeight = accordionItemBody.scrollHeight + "px";
    }
    else {
      accordionItemBody.style.maxHeight = 0;
    }
    
  });
});

//insurence end

// digital gold start
function convertRupeesValue() {
  // Get the element input value
  var elementValue = document.getElementById('goldpriceinput').value;

  // Convert the element value to grams
  var gramValue = elementValue / 6011.07;

  if (elementValue < 10) {
    document.getElementById("alertmsg").innerHTML = "Please enter minimum Rs. 10";
    print 
    gramValue = 0; // Exit the function without printing the value

  }else{
    document.getElementById("alertmsg").innerHTML = "";
  }

   if(elementValue < 0 ) {
    elementValue = 0;
  };

  // Update the gram input field with the converted value
  document.getElementById('goldgraminput').value = gramValue;
  document.getElementById('goldpriceinput').value = elementValue;
}

function ruppesvalue(value) {
  // Get the current input value
  var elementInput = document.getElementById('goldpriceinput');
  var currentValue = value;

  // Append the value of the clicked element
  var newValue = parseInt(currentValue);

  // Update the input field with the new value
  elementInput.value = newValue;

  // Convert the new value to grams
  convertRupeesValue();
}

// Add event listener to the element input field
document.getElementById('goldpriceinput').addEventListener('input', convertRupeesValue);

// -----------------

function convertGramValue() {
  // Get the element input value
  var elementValue = document.getElementById('switchgoldgraminput').value;

  // Convert the element value to grams
  var gramValue = elementValue * 6011.07;

  // if(elementValue == 0){
  //   elementValue = 1
  //   gramValue = 6011.07
  // } else if(gramValue <= 0){
  //   elementValue = 0
  // }
  if(elementValue < 0) {
    print 
    gramValue = 0
    elementValue = 0;

  };

  // Update the gram input field with the converted value
  document.getElementById('switchgoldpriceinput').value = gramValue;
  document.getElementById('switchgoldgraminput').value = elementValue;
}

function gramvalue(value) {
  // Get the current input value
  const elementInput = document.getElementById('switchgoldgraminput');
  var currentValue = value;

  // Append the value of the clicked element
  var newValue = parseInt(currentValue);

  // Update the input field with the new value
  elementInput.value = newValue;

  // Convert the new value to grams
  convertGramValue();
}

// Add event listener to the element input field
document.getElementById('switchgoldgraminput').addEventListener('input', convertGramValue);


//-------------------- for silver logics
function convertsilverRupeesValue() {
  // Get the element input value
  var elementValue = document.getElementById('silverpriceinput').value;

  // Convert the element value to grams
  var gramValue = elementValue / 732.89;

 
  if (elementValue < 10) {
    document.getElementById("silveralertmsg").innerHTML = "Please enter minimum Rs. 10";
    print 
    gramValue = 0; // Exit the function without printing the value

  }else{    
    document.getElementById("silveralertmsg").innerHTML = "";
  }

   if(elementValue < 0) {
    elementValue = 0;
  };

  // Update the gram input field with the converted value
  document.getElementById('silvergraminput').value = gramValue;
  document.getElementById('silverpriceinput').value = elementValue;
}

function silverruppesvalue(value) {
  // Get the current input value
  var elementInput = document.getElementById('silverpriceinput');
  var currentValue = value;

  // Append the value of the clicked element
  var newValue = parseInt(currentValue);

  // Update the input field with the new value
  elementInput.value = newValue;

  // Convert the new value to grams
  convertsilverRupeesValue();
}

// Add event listener to the element input field
document.getElementById('silverpriceinput').addEventListener('input', convertsilverRupeesValue);

// -----------------

function convertSilverGramValue() {
  // Get the element input value
  var elementValue = document.getElementById('switchsilvergraminputs').value;

  // Convert the element value to grams
  var gramValue = elementValue * 732.89;

  // if(elementValue == 0){
  //   elementValue = 1
  //   gramValue = 732.89
  // }
  if(elementValue < 0) {
    print 
    gramValue = 0
    elementValue = 0;

  };

  // Update the gram input field with the converted value
  document.getElementById('switchsilverpriceinput').value = gramValue;
  document.getElementById('switchsilvergraminputs').value = elementValue;
}

function silvergramvalue(value) {
  // Get the current input value
  const elementInput = document.getElementById('switchsilvergraminputs');
  var currentValue = value;

  // Append the value of the clicked element
  var newValue = parseInt(currentValue);

  // Update the input field with the new value
  elementInput.value = newValue;

  // Convert the new value to grams
  convertSilverGramValue();
}

// Add event listener to the element input field
document.getElementById('switchsilvergraminputs').addEventListener('input', convertSilverGramValue);




// Get all navbar links
const goldsilvermainbtn = document.querySelectorAll('.goldsilvermainbtn');

// Get all content sections
const goldsilverboxcontent = document.querySelectorAll('.goldsilverboxcontent');

// Add click event listener to each navbar link
goldsilvermainbtn.forEach(link => {
  link.addEventListener('click', (event) => {

    // Remove active class from all navbar links
    goldsilvermainbtn.forEach(link => {
      link.classList.remove('active');
    });

    // Add active class to the clicked link
    link.classList.add('active');

    // Get the target section from the link's data attribute
    const targetSection = link.dataset.target;

    // Show the target section and hide others
    goldsilverboxcontent.forEach(section => {
      if (section.id === targetSection) {
        section.style.display = 'block';
      } else {
        section.style.display = 'none';
      }
    });
  });
});

// Get all Gold ruppes and grams links
const rupeesbtn = document.querySelectorAll('.rupeesbtn');

// Get all content sections
const switchinput = document.querySelectorAll('.switchinput');

// Add click event listener to each navbar link
rupeesbtn.forEach(link => {
  link.addEventListener('click', (event) => {

    // Remove active class from all navbar links
    rupeesbtn.forEach(link => {
      link.classList.remove('active');
    });

    // Add active class to the clicked link
    link.classList.add('active');

    // Get the target section from the link's data attribute
    const targetSection = link.dataset.target;

    // Show the target section and hide others
    switchinput.forEach(section => {
      if (section.id === targetSection) {
        section.style.display = 'block';
      } else {
        section.style.display = 'none';
      }
    });
  });
});


// Get all silver rupees and grams navbar links
const silverrupeesbtn = document.querySelectorAll('.silverrupeesbtn');

// Get all content sections
const switchsilverinput = document.querySelectorAll('.switchsilverinput');

// Add click event listener to each navbar link
silverrupeesbtn.forEach(link => {
  link.addEventListener('click', (event) => {

    // Remove active class from all navbar links
    silverrupeesbtn.forEach(link => {
      link.classList.remove('active');
    });

    // Add active class to the clicked link
    link.classList.add('active');

    // Get the target section from the link's data attribute
    const targetSection = link.dataset.target;

    // Show the target section and hide others
    switchsilverinput.forEach(section => {
      if (section.id === targetSection) {
        section.style.display = 'block';
      } else {
        section.style.display = 'none';
      }
    });
  });
});




// Get all navbar links
const buysell = document.querySelectorAll('.hiw_buy');

// Get all content sections
const contentSections = document.querySelectorAll('.content-section');

// Add click event listener to each navbar link
buysell.forEach(link => {
  link.addEventListener('click', (event) => {

    // Remove active class from all navbar links
    buysell.forEach(link => {
      link.classList.remove('active');
    });

    // Add active class to the clicked link
    link.classList.add('active');

    // Get the target section from the link's data attribute
    const targetSection = link.dataset.target;

    // Show the target section and hide others
    contentSections.forEach(section => {
      if (section.id === targetSection) {
        section.style.display = 'block';
      } else {
        section.style.display = 'none';
      }
    });
  });
});



const tabs = document.querySelectorAll('[data-tab-target]');
const tabcontents = document.querySelectorAll('[data-tab-content]');

tabs.forEach(tab => {
    tab.addEventListener('click', ()=>{
        const target = document.querySelector(tab.dataset.tabTarget)
        tabcontents.forEach(tabcontent => {
            tabcontent.classList.remove('active')
        })
        tabs.forEach(tab => {
            tab.classList.remove('active')
        })
        tab.classList.add('active')
        target.classList.add('active')
    })
})


//banner gold silver js start
