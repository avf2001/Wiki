# Patterns
- [Stack](#stack)
  - Using CSS Grid
- Inline-Cluster
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

## Inline-Cluster

### Using CSS Grid
```html
<style>
    [data-inline-cluster] {
        --gutter: initial;
        display: grid;
        gap: var(--gutter, 0px);
        grid-auto-flow: column;
        align-items: center;
        justify-content: start;
    }
</style>
...
<body>
    <ul data-inline-cluster>
        <li>item1</li>
        <li>item2</li>
        <li>item3</li>
        <li>item4</li>
    </ul>
</body>
```
