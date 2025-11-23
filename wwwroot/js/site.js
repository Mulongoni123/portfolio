// Initialize AOS animations
AOS.init({
    duration: 1000,
    once: true,
    offset: 100
});

// Navbar background on scroll
window.addEventListener('scroll', function () {
    const navbar = document.querySelector('.navbar');
    if (window.scrollY > 100) {
        navbar.style.background = 'rgba(255, 255, 255, 0.98)';
        navbar.style.boxShadow = '0 5px 20px rgba(0,0,0,0.1)';
    } else {
        navbar.style.background = 'rgba(255, 255, 255, 0.95)';
        navbar.style.boxShadow = '0 10px 30px rgba(0,0,0,0.1)';
    }
});

// Smooth scrolling for anchor links
document.querySelectorAll('a[href^="#"]').forEach(function (anchor) {
    anchor.addEventListener('click', function (e) {
        e.preventDefault();
        const target = document.querySelector(this.getAttribute('href'));
        if (target) {
            target.scrollIntoView({
                behavior: 'smooth',
                block: 'start'
            });
        }
    });
});

// Typing effect for hero title
function typeWriter(element, text, speed) {
    if (speed === void 0) { speed = 100; }
    let i = 0;
    element.innerHTML = '';

    function type() {
        if (i < text.length) {
            element.innerHTML += text.charAt(i);
            i++;
            setTimeout(type, speed);
        }
    }
    type();
}

// Initialize typing effect when page loads
document.addEventListener('DOMContentLoaded', function () {
    const heroTitle = document.querySelector('.hero-title');
    if (heroTitle) {
        const originalText = heroTitle.textContent;
        typeWriter(heroTitle, originalText);
    }

    // Add loading animation
    const loader = document.createElement('div');
    loader.className = 'page-loader';
    loader.innerHTML = '<div class="spinner-border text-primary" role="status"><span class="visually-hidden">Loading...</span></div>';
    document.body.appendChild(loader);

    // Remove loader when page is loaded
    window.addEventListener('load', function () {
        setTimeout(function () {
            loader.style.opacity = '0';
            setTimeout(function () {
                if (loader.parentNode) {
                    loader.parentNode.removeChild(loader);
                }
            }, 300);
        }, 500);
    });
});

// Skill progress bars animation
function animateSkillBars() {
    const skillBars = document.querySelectorAll('.progress-bar');
    skillBars.forEach(function (bar) {
        const width = bar.style.width;
        bar.style.width = '0';
        setTimeout(function () {
            bar.style.width = width;
        }, 500);
    });
}

// Intersection Observer for animations
const observerOptions = {
    threshold: 0.1,
    rootMargin: '0px 0px -50px 0px'
};

const observer = new IntersectionObserver(function (entries) {
    entries.forEach(function (entry) {
        if (entry.isIntersecting) {
            entry.target.classList.add('animated');
            if (entry.target.classList.contains('skill-bar')) {
                animateSkillBars();
            }
        }
    });
}, observerOptions);

// Observe elements for animation
document.addEventListener('DOMContentLoaded', function () {
    const animateElements = document.querySelectorAll('[data-aos]');
    animateElements.forEach(function (el) {
        observer.observe(el);
    });
});

// Contact form handling
function initializeContactForm() {
    const contactForm = document.getElementById('contactForm');
    if (!contactForm) return;

    // Add real-time validation
    const inputs = contactForm.querySelectorAll('input, textarea');

    function validateField(field) {
        const value = field.value.trim();
        const fieldName = field.getAttribute('name');

        // Clear previous validation
        field.classList.remove('is-invalid', 'is-valid');

        if (field.hasAttribute('required') && !value) {
            field.classList.add('is-invalid');
            return false;
        }

        if (fieldName === 'Email' && value) {
            const emailRegex = new RegExp("^[^\\s@]+@[^\\s@]+\\.[^\\s@]+$");
            if (!emailRegex.test(value)) {
                field.classList.add('is-invalid');
                return false;
            }
        }

        if (value) {
            field.classList.add('is-valid');
        }

        return true;
    }

    inputs.forEach(function (input) {
        input.addEventListener('blur', function () {
            validateField(this);
        });

        input.addEventListener('input', function () {
            if (this.classList.contains('is-invalid')) {
                validateField(this);
            }
        });
    });

    contactForm.addEventListener('submit', function (e) {
        let isValid = true;

        // Validate all fields before submission
        inputs.forEach(function (input) {
            if (!validateField(input)) {
                isValid = false;
            }
        });

        if (!isValid) {
            e.preventDefault();
            return;
        }

        const submitBtn = this.querySelector('button[type="submit"]');
        const originalText = submitBtn.innerHTML;

        // Add loading state
        submitBtn.innerHTML = '<i class="fas fa-spinner fa-spin me-2"></i>Sending...';
        submitBtn.disabled = true;

        // Allow form to submit normally
        setTimeout(function () {
            submitBtn.innerHTML = originalText;
            submitBtn.disabled = false;
        }, 3000);
    });
}

// Initialize contact form when DOM is loaded
document.addEventListener('DOMContentLoaded', function () {
    initializeContactForm();
});

// Visitor counter with localStorage
document.addEventListener('DOMContentLoaded', function () {
    let visitorCount = localStorage.getItem('visitorCount');
    if (!visitorCount) {
        visitorCount = 1;
    } else {
        visitorCount = parseInt(visitorCount) + 1;
    }
    localStorage.setItem('visitorCount', visitorCount);
    document.getElementById('visitorCount').textContent = visitorCount;

    // Initialize games
    initializeSkillGame();
    initializeTimelineGame();
});

// Skill unlock game
function initializeSkillGame() {
    const skillCards = document.querySelectorAll('.skill-game-card');

    skillCards.forEach(card => {
        card.addEventListener('click', function () {
            if (!this.classList.contains('unlocked')) {
                this.classList.add('unlocked');

                // Animate progress bars
                const progressBars = this.querySelectorAll('.progress-bar');
                progressBars.forEach(bar => {
                    const skillLevel = bar.parentElement.parentElement.getAttribute('data-level');
                    setTimeout(() => {
                        bar.style.width = skillLevel + '%';
                    }, 300);
                });
            }
        });
    });
}

// Timeline animation
function initializeTimelineGame() {
    const exploreBtn = document.getElementById('exploreTimeline');
    const timelineFill = document.getElementById('timelineFill');
    const milestones = document.querySelectorAll('.milestone');

    if (exploreBtn) {
        exploreBtn.addEventListener('click', function () {
            // Animate timeline progress
            timelineFill.style.width = '66%'; // 4 out of 6 milestones completed

            // Reveal completed milestones with delay
            milestones.forEach((milestone, index) => {
                if (milestone.classList.contains('completed')) {
                    setTimeout(() => {
                        milestone.style.opacity = '1';
                        milestone.style.transform = 'translateX(0)';
                    }, index * 300);
                }
            });

            // Change button text
            this.innerHTML = '<i class="fas fa-check me-2"></i>Journey Explored!';
            this.classList.remove('btn-outline-primary');
            this.classList.add('btn-success');
            this.disabled = true;
        });
    }
}


