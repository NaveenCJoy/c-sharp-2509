imageLinks = [
  "https://images01.nicepagecdn.com/c461c07a441a5d220e8feb1a/973e7b71cc2e5de2a6364059/bvvvvv.jpg",
  "https://images01.nicepagecdn.com/c461c07a441a5d220e8feb1a/e9b7d28c1320536f89b69106/nb.jpg",
  "https://images01.nicepagecdn.com/c461c07a441a5d220e8feb1a/ac3b09f013c455f1be302b93/2.jpg",
  "https://images02.nicepagecdn.com/c461c07a441a5d220e8feb1a/9aed9ba7ac2455269e565127/debossed-logo-mockup-kraft-paper_149660-758.jpg",
  "https://images02.nicepagecdn.com/c461c07a441a5d220e8feb1a/2fab027daf5856dfa9864afe/3d-logo-mockup-modern-facade-sign_145275-209.jpg",
  "https://images01.nicepagecdn.com/c461c07a441a5d220e8feb1a/4f42bf0df1b3556db8f7990d/jhjj.jpg",
];

let i = 0;
document.getElementById("image").src = imageLinks[i];
const nextImage = () => {
  if (i < imageLinks.length - 1) {
    i += 1;
  }
  document.getElementById("image").src = imageLinks[i];
};

const prevImage = () => {
  if (i > 0) {
    i -= 1;
  }
  document.getElementById("image").src = imageLinks[i];
};
