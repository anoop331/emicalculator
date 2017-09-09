# emicalculator
An windows forms application that calculates the monthly emi, based on the tenure in number of months, the annual rate, and the total loan amount (principle).
The calculation is based on the formula.

x(n) = p(1 + r/100)^n /  (1 + (1+r/100) + (1+r/100)^2 + (1+r/100)^3 ... (1+r/100)^n-1)

Where x is the equally distributed emi over "n" number of months, for an initial principle of "p", with a monthly interest rate of "r%".
