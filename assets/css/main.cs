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

/* -----------------------------------------------------------
   Hero Section
   ----------------------------------------------------------- */

.hero {
  padding: var(--space-4) 0;
  text-align: left;
}

.hero h1 {
  font-size: 3rem;
  font-weight: 700;
  margin-bottom: var(--space-2);
}

.tagline {
  font-size: 1.4rem;
  font-weight: 500;
  color: var(--subtle);
  margin-bottom: var(--space-2);
}

.intro {
  max-width: 600px;
  margin-bottom: var(--space-3);
  color: var(--subtle);
}

.cta {
  display: inline-block;
  padding: 0.75rem 1.5rem;
  background: var(--accent);
  color: white;
  border-radius: var(--radius);
  text-decoration: none;
  font-weight: 600;
  transition: background 0.2s, transform 0.2s;
}

.cta:hover {
  background: #2f6ae0;
  transform: translateY(-2px);
}