// Grabbing HTML elements and storing them in variables for easy access.
const exchangeButton = document.getElementById("exchange-button");
const amountInput = document.getElementById("amount");
const currencyFromSelect = document.getElementById("currency-from");
const currencyToSelect = document.getElementById("currency-to");
const resultDiv = document.getElementById("result");

// Attach a click event listener to the exchange button
exchangeButton.addEventListener("click", exchange);

// Function to handle the currency exchange
async function exchange() {
  try {

    // Get user input values
    const amount = amountInput.value;
    const currencyFrom = currencyFromSelect.value;
    const currencyTo = currencyToSelect.value;

    // Fetch exchange rate data from the API
    const response = await fetch(`https://v6.exchangerate-api.com/v6/62df76a4adca2e213a58a443/latest/${currencyFrom}`);
    if (!response.ok) {
      throw new Error('Network response was not ok');
    }

    // Parse the JSON response
    const data = await response.json();
    const exchangeRate = data.conversion_rates[currencyTo];

    // Calculate and display the exchanged amount
    if (exchangeRate) {
      const exchangedAmount = (amount * exchangeRate).toFixed(2);
      resultDiv.textContent = `${amount} ${currencyFrom} = ${exchangedAmount} ${currencyTo}`;
      addConversionSummary(amount, currencyFrom, exchangedAmount, currencyTo);
    } else {
      throw new Error('Exchange rate not available.');
    }
  } catch (error) {
    // Display error message in case of an exception
    resultDiv.textContent = `Error: ${error.message}`;
  }
}


// Function to add a summary of the conversion
function addConversionSummary(amountFrom, currencyFrom, amountTo, currencyTo) {
  const summaryDiv = document.getElementById("conversion-summary");
  const newEntry = document.createElement("p");
  newEntry.textContent = `Converted ${amountFrom} ${currencyFrom} to ${amountTo} ${currencyTo}`;
  newEntry.classList.add("conversion-entry");
  summaryDiv.appendChild(newEntry);
}


