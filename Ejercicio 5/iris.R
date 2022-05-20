iris
class(iris)
colnames(iris)
iris$Petal.Length
plot(iris$Petal.Length, iris$Petal.Width)
plot(iris$Petal.Length, iris$Petal.Width, pch=21, bg=c("red","green3","blue")[unclass(iris$Species)])
plot(iris[1:4], pch = 21, bg = c("red", "green3", "blue")[unclass(iris$Species)])