module Lambdas where

helloworld = putStrLn "Hello, World!"



sqr :: Num a => a -> a

sqr = \x -> x * x

pythagorean :: Double -> (Double -> Double)
pythagorean = \x -> (\y -> sqrt (sqr x + sqr y))

mySum ls = foldl (\a b -> a + b) 0 ls
