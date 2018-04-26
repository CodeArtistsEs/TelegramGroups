for (let number = 1; number <= 100; number++) {
  const fizz = number % 3 == 0, buzz = number % 5 == 0;
  console.log(
    fizz && buzz ? "FizzBuzz" : (fizz ? "Fizz" : (buzz ? "Buzz" : number))
  );
}
