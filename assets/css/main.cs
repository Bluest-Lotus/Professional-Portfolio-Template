/* -----------------------------------------------------------
   Global Design System
   ----------------------------------------------------------- */

:root {
  --font-body: "Inter", system-ui, sans-serif;

  --space-1: 0.5rem;
  --space-2: 1rem;
  --space-3: 2rem;
  --space-4: 4rem;

  --radius: 8px;
  --shadow: 0 4px 12px rgba(0,0,0,0.08);

  --bg: #ffffff;
  --text: #1a1a1a;
  --subtle: #555;
  --accent: #3a7afe;
}

[data-theme="dark"] {
  --bg: #0f0f0f;
  --text: #eaeaea;
  --subtle: #aaa;
  --accent: #6ea2ff;
}

/* Base */

body {
  margin: 0;
  background: var(--bg);
  color: var(--text);
  font-family: var(--font-body);
  line-height: 1.6;
}

.container {
  max-width: 900px;
  margin: auto;
  padding: var(--space-3) var(--space-2);
}

/* Navigation */

.site-header {
  border-bottom: 1px solid rgba(0,0,0,0.08);
  padding: var(--space-2) 0;
}

.nav {
  display: flex;
  align-items: center;
  gap: var(--space-2);
}

.nav a {
  text-decoration: none;
  color: var(--text);
  font-weight: 500;
  padding: 0.25rem 0.5rem;
  border-radius: var(--radius);
  transition: background 0.2s;
}

.nav a:hover {
  background: rgba(0,0,0,0.05);
}

/* Hero */

.hero {
  padding: var(--space-4) 0;
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

/* Project Grid */

.project-grid {
  display: grid;
  gap: var(--space-2);
  grid-template-columns: repeat(auto-fit, minmax(260px, 1fr));
  margin-top: var(--space-3);
}

.project-card {
  background: rgba(0,0,0,0.03);
  padding: var(--space-2);
  border-radius: var(--radius);
  text-decoration: none;
  color: var(--text);
  transition: transform 0.15s, box-shadow 0.15s;
}

.project-card:hover {
  transform: translateY(-2px);
  box-shadow: var(--shadow);
}

/* Footer */

.site-footer {
  margin-top: var(--space-4);
  padding: var(--space-2) 0;
  text-align: center;
  color: var(--subtle);
  font-size: 0.9rem;
}