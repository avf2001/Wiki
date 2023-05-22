# Content
* [Flex](#flex)
* [Grid](#grid)
* [CSS Position](#css-position)
* [Margin](#margin)

Source: https://tproger.ru/articles/kak-centrirovat-chto-ugodno-v-css/
```html
<div class="container">
  <div class="box-1"></div>
</div>
```
# Flex
```css
.container {
  display: flex;
  height: 100vh; /* высота контейнера 100% от кона браузера */
  justify-content: center; /* выравнивание по центру контейнера по горизонтали */
  align-items: center; /* выравнивание по центру по горизонтали */
}
```
# Grid
```css
.container {
  display: grid;
  height: 100vh; /* высота контейнера 100% от кона браузера */
  justify-content: center; /* выравнивание по центру контейнера по горизонтали */
  align-content: center; /* выравнивание по центру по горизонтали */
  
  place-content: center; /* одновременное выравнивание по вертикали и горизонтали */
}
```
# CSS Position
```css
.container {
  height: 100vh;
  position: relative;
}
.box-1 {
  position: absolute;
  
  /* горизонтальное выравнивание */
  left: 50%;
  transform: translate(-50%);
  
  /* вертикальное выравнивание */
  top: 50%;
  transform: translate(0, -50%);
  
  /* горизонтальное и вертикальное выравнивание */
  top: 50%;
  left: 50%;
  transform: translate(-50%,-50%);
}
```
# Margin
```css
.container{
  display: flex;
  height: 100vh;  
}
.box-1 {
  /* горизонтальное выравнивание */
  margin: 0px auto;
  
  /* вертикальное выравнивание */
  margin: auto 0px;
  
  /* горизонтальное и вертикальное выравнивание */
  margin: auto;
}
```
