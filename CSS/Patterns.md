# Patterns
- [Stack](#stack)
  - Using CSS Grid
  - Using Flex
- Inline-Cluster
  - Using CSS Grid
- Split
  - Using CSS Grid
- Cover
  - Using CSS Grid
- Center
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

### Using Flex
```html
<style>
    [data-stack] {
        --gutter: initial;
        display: flex;
        flex-direction: column;
        gap: var(--gutter, 0px);        
    }
</style>
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

## Split

### Using CSS Grid
```html
<style>
    [data-split] {
        --gutter: initial;
        display: grid;
        gap: var(--gutter, 0px);
        grid-template-columns: 1fr 2fr;
    }
</style>
...
<body>
    <div data-split>
        <div>1</div>
        <div>2</div>
        <div>3</div>
        <div>4</div>
    </div>
</body>
```

## Cover

### Using CSS Grid
```html
<style>
    [data-cover] {
        --gutter: initial;
        --minHeight: initial;
        display: grid;
        gap: var(--gutter, 0px);
        min-block-size: var(--minHeight, 100vh);
    }
    [data-cover] > [data-cover-centered] {
        align-self: center;
    }
</style>
...
<body>
    <div data-cover>
        <div data-cover-centered>1</div>
    </div>
</body>
```

## Center

### Using CSS Grid
```html

```
