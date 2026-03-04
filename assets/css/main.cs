:root {
  --bg: #ffffff;
  --text: #111111;
  --accent: #0077ff;
  --radius: 6px;
  --space: 1rem;
}

[data-theme="dark"] {
  --bg: #111111;
  --text: #f5f5f5;
  --accent: #4da3ff;
}

body {
  background: var(--bg);
  color: var(--text);
  font-family: system-ui, sans-serif;
  margin: 0;
  padding: 0;
}

.container {
  max-width: 900px;
  margin: auto;
  padding: var(--space);
}

nav a {
  margin-right: var(--space);
}

button#theme-toggle {
  background: none;
  border: none;
  cursor: pointer;
  font-size: 1.2rem;
}