﻿# Potter-kata
## Problem Description

<p>
Once upon a time there was a series of 5 books about a very English hero called Harry. (At
least when this Kata was invented, there were only 5. Since then they have multiplied).
Children all over the world thought he was fantastic, and, of course, so did the publisher. So
in a gesture of immense generosity to mankind, (and to increase sales) they set up the
following pricing model to take advantage of Harry’s magical powers.
</p>
<p>
One copy of any of the five books costs 8 EUR. If, however, you buy two different books
from the series, you get a 5% discount on those two books. If you buy 3 different books, you
get a 10% discount. With 4 different books, you get a 20% discount. If you go the whole hog,
and buy all 5, you get a huge 25% discount.
</p>
<p>
Note that if you buy, say, four books, of which 3 are different titles, you get a 10% discount
on the 3 that form part of a set, but the fourth book still costs 8 EUR.
</p>
<p>
Potter mania is sweeping the country and parents of teenagers everywhere are queueing up
with shopping baskets overflowing with Potter books. Your mission is to write a piece of
code to calculate the price of any conceivable shopping basket, giving as big a discount as
possible.
</p>

## Solution
<p>
The problem seems simple at first, but it is a bit tricky. We could just add all the books in the set up to 5 and then apply the discount,
but in the scenario where we have all 5 books of the series plus another 3 in the basket this solution would apply a discount as: (5 * 8 * 0.75 + 3 * 8 * 0.9) = 51.6
but the optimal solution should be: (4 * 8 * 0.80 + 4 * 8 * 0.80) = 51.2
</p>

<p>
The solution I came up with breaks the basket into discount sets. The goal is to maximize the number of sets with the maximum discount possible.
This is done as follows:
</p>

```
sort the basket by book volume.
for each book in the basket:
   attempt to add the book to an existing discount set that does not contain it by:
      - finding the set with the minimum total price after adding the book.
      - add the book to the best discount set found.
   if the book cannot be added to any existing set or if there are no existing sets:
      - create a new discount set and add the book to this set.
calculate and return the total price of the basket after applying discounts.
```