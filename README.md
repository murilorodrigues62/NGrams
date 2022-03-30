# NGrams
A simple script to generate a set of [n-grams](http://en.wikipedia.org/wiki/N-gram) from a string of text.  
This app generate a set of every permutation of contiguous n-grams from a string of text, from 1-gram to n-grams where n is the number of words in the string

## Example
```js
"Show me the code."
```

### Returns
```js
[
  "Show",
  "Show me",
  "Show me the",
  "Show me the code",
  "me",
  "me the",
  "me the code",
  "the",
  "the code",
  "code"
]
```
