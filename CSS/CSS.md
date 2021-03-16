# text-overflow
```css
div{
  width:100px;   
}
p{
  background:red;
  font-size:2rem;
}
.first{
  white-space:nowrap;
}
.second{
  white-space:pre;
}
.third{
  white-space:pre-line;
}
.fourth{
  white-space:nowrap;
  text-overflow:ellipsis;
  overflow:hidden;
}
```
```html
<div>
  <p class="zero">Some text</p>
  <p class='first'>Some text</p>
  <p class='second'>Some text</p>
  <p class='third'>Some text</p>
  <p class='fourth'>Some text</p>
</div>
```
