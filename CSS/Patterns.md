# Patterns
- [Stack](#stack)
  - Using CSS Grid

## Stack
### Using CSS Grid
```html
<style>
    [data-stack] {
        --gutter: initial;
        display: grid;
        gap: var(--gutter, 0px);
        align-content: start;
    }
</style>
...
<body>
    <nav data-stack>1</nav>
    <nav data-stack>2</nav>
</body>
```
