using System;
using Microsoft.EntityFrameworkCore;
using QuotesApp.Domain.Entities;

namespace QuotesApp.Infrastructure.Seeds
{
    public static class SeedingExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Quote>().HasData(
                            new Quote
                            {
                                Id = 1,
                                Text = "Life is about making an impact, not making an income.",
                                Author = "Kevin Kruse",
                                CreatedAt = DateTime.Today
                            },
            new Quote
            {
                Id = 2,
                Text = "Whatever the mind of man can conceive and believe, it can achieve.",
                Author = "Napoleon Hill",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 3,
                Text = "Strive not to be a success, but rather to be of value.",
                Author = "Albert Einstein",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 4,
                Text = "Two roads diverged in a wood, and I—I took the one less traveled by, And that has made all the difference. ",
                Author = "Robert Frost",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 5,
                Text = "I attribute my success to this: I never gave or took any excuse.",
                Author = "Florence Nightingale",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 6,
                Text = "You miss 100% of the shots you don’t take.",
                Author = "Wayne Gretzky",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 7,
                Text = "I've missed more than 9000 shots in my career. I've lost almost 300 games. 26 times I've been trusted to take the game winning shot and missed. I've failed over and over and over again in my life. And that is why I succeed.",
                Author = "Michael Jordan",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 8,
                Text = "The most difficult thing is the decision to act, the rest is merely tenacity.",
                Author = "Amelia Earhart",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 9,
                Text = "Every strike brings me closer to the next home run.",
                Author = "Babe Ruth",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 10,
                Text = "Definiteness of purpose is the starting point of all achievement.",
                Author = "W. Clement Stone",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 11,
                Text = "Life isn't about getting and having, it's about giving and being.",
                Author = "Kevin Kruse",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 12,
                Text = "Life is what happens to you while you’re busy making other plans.",
                Author = "John Lennon",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 13,
                Text = "We become what we think about.",
                Author = "Earl Nightingale",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 14,
                Text = "Twenty years from now you will be more disappointed by the things that you didn’t do than by the ones you did do, so throw off the bowlines, sail away from safe harbor, catch the trade winds in your sails.  Explore, Dream, Discover.",
                Author = "Mark Twain",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 15,
                Text = "Life is 10% what happens to me and 90% of how I react to it.",
                Author = "Charles Swindoll",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 16,
                Text = "The most common way people give up their power is by thinking they don’t have any.",
                Author = "Alice Walker",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 17,
                Text = "The mind is everything. What you think you become. ",
                Author = "Buddha",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 18,
                Text = "The best time to plant a tree was 20 years ago. The second best time is now.",
                Author = "Chinese Proverb",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 19,
                Text = "An unexamined life is not worth living.",
                Author = "Socrates",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 20,
                Text = "Eighty percent of success is showing up.",
                Author = "Woody Allen",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 21,
                Text = "Your time is limited, so don’t waste it living someone else’s life.",
                Author = "Steve Jobs",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 22,
                Text = "Winning isn’t everything, but wanting to win is.",
                Author = "Vince Lombardi",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 23,
                Text = "I am not a product of my circumstances. I am a product of my decisions.",
                Author = "Stephen Covey",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 24,
                Text = "Every child is an artist.  The problem is how to remain an artist once he grows up.",
                Author = "Pablo Picasso",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 25,
                Text = "You can never cross the ocean until you have the courage to lose sight of the shore.",
                Author = "Christopher Columbus",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 26,
                Text = "I’ve learned that people will forget what you said, people will forget what you did, but people will never forget how you made them feel.",
                Author = "Maya Angelou",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 27,
                Text = "Either you run the day, or the day runs you.",
                Author = "Jim Rohn",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 28,
                Text = "Whether you think you can or you think you can’t, you’re right.",
                Author = "Henry Ford",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 29,
                Text = "The two most important days in your life are the day you are born and the day you find out why.",
                Author = "Mark Twain",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 30,
                Text = "Whatever you can do, or dream you can, begin it.  Boldness has genius, power and magic in it.",
                Author = "Johann Wolfgang von Goethe",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 31,
                Text = "The best revenge is massive success.",
                Author = "Frank Sinatra",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 32,
                Text = "People often say that motivation doesn’t last. Well, neither does bathing.  That’s why we recommend it daily.",
                Author = "Zig Ziglar",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 33,
                Text = "Life shrinks or expands in proportion to one's courage.",
                Author = "Anais Nin",
                CreatedAt = DateTime.Today
            },

            new Quote
            {
                Id = 34,
                Text = "If you hear a voice within you say “you cannot paint,” then by all means paint and that voice will be silenced.",
                Author = "Vincent Van Gogh",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 35,
                Text = "There is only one way to avoid criticism: do nothing, say nothing, and be nothing.",
                Author = "Aristotle",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 36,
                Text = "Ask and it will be given to you; search, and you will find; knock and the door will be opened for you.",
                Author = "Jesus",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 37,
                Text = "The only person you are destined to become is the person you decide to be.",
                Author = "Ralph Waldo Emerson",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 38,
                Text = "Go confidently in the direction of your dreams.  Live the life you have imagined.",
                Author = "Henry David Thoreau",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 39,
                Text = "When I stand before God at the end of my life, I would hope that I would not have a single bit of talent left and could say, I used everything you gave me.",
                Author = "Erma Bombeck",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 40,
                Text = "Few things can help an individual more than to place responsibility on him, and to let him know that you trust him. ",
                Author = "Booker T. Washington",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 41,
                Text = "Certain things catch your eye, but pursue only those that capture the heart.",
                Author = " Ancient Indian Proverb",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 42,
                Text = "Believe you can and you’re halfway there.",
                Author = "Theodore Roosevelt",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 43,
                Text = "Everything you’ve ever wanted is on the other side of fear.",
                Author = "George Addair",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 44,
                Text = "We can easily forgive a child who is afraid of the dark; the real tragedy of life is when men are afraid of the light.",
                Author = "Plato",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 45,
                Text = "Teach thy tongue to say, \"I do not know,\" and thous shalt progress.",
                Author = "Maimonides",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 46,
                Text = "Start where you are. Use what you have. Do what you can.",
                Author = "Arthur Ashe",
                CreatedAt = DateTime.Today
            },
             new Quote
             {
                 Id = 47,
                 Text = "When I was 5 years old, my mother always told me that happiness was the key to life. When I went to school, they asked me what I wanted to be when I grew up.I wrote down 'happy'. They told me I didn’t understand the assignment, and I told them they didn’t understande life.",
                 Author = "John Lennon",
                 CreatedAt = DateTime.Today
             },
            new Quote
            {
                Id = 48,
                Text = "Fall seven times and stand up eight.",
                Author = "Japanese Proverb",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 49,
                Text = "When one door of happiness closes, another opens, but often we look so long at the closed door that we do not see the one that has been opened for us.",
                Author = "Helen Keller",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 50,
                Text = "Everything has beauty, but not everyone can see.",
                Author = "Confucius",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 51,
                Text = "How wonderful it is that nobody need wait a single moment before starting to improve the world.",
                Author = "Anne Frank",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 52,
                Text = "When I let go of what I am, I become what I might be.",
                Author = "Lao Tzu",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 53,
                Text = "Life is not measured by the number of breaths we take, but by the moments that take our breath away.",
                Author = "Maya Angelou",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 54,
                Text = "Happiness is not something readymade.  It comes from your own actions.",
                Author = "Dalai Lama",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 55,
                Text = "If you're offered a seat on a rocket ship, don't ask what seat! Just get on.",
                Author = "Sheryl Sandberg",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 56,
                Text = "First, have a definite, clear practical ideal; a goal, an objective. Second, have the necessary means to achieve your ends; wisdom, money, materials, and methods. Third, adjust all your means to that end.",
                Author = "Aristotle",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 57,
                Text = "If the wind will not serve, take to the oars.",
                Author = "Latin Proverb",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 58,
                Text = "You can’t fall if you don’t climb.  But there’s no joy in living your whole life on the ground.",
                Author = "Unknown",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 59,
                Text = "We must believe that we are gifted for something, and that this thing, at whatever cost, must be attained.",
                Author = "Marie Curie",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 60,
                Text = "Too many of us are not living our dreams because we are living our fears.",
                Author = "Les Brown",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 61,
                Text = "Challenges are what make life interesting and overcoming them is what makes life meaningful.",
                Author = "Joshua J. Marine",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 62,
                Text = "If you want to lift yourself up, lift up someone else.",
                Author = "Booker T. Washington",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 63,
                Text = "I have been impressed with the urgency of doing. Knowing is not enough; we must apply. Being willing is not enough; we must do.",
                Author = "Leonardo da Vinci",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 64,
                Text = "Limitations live only in our minds.  But if we use our imaginations, our possibilities become limitless.",
                Author = "Jamie Paolinetti",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 65,
                Text = "You take your life in your own hands, and what happens? A terrible thing, no one to blame.",
                Author = "Erica Jong",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 66,
                Text = "What’s money? A man is a success if he gets up in the morning and goes to bed at night and in between does what he wants to do.",
                Author = "Bob Dylan",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 67,
                Text = "I didn’t fail the test. I just found 100 ways to do it wrong.",
                Author = "Benjamin Franklin",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 68,
                Text = "In order to succeed, your desire for success should be greater than your fear of failure.",
                Author = "Bill Cosby",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 69,
                Text = "A person who never made a mistake never tried anything new.",
                Author = " Albert Einstein",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 70,
                Text = "The person who says it cannot be done should not interrupt the person who is doing it.",
                Author = "Chinese Proverb",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 71,
                Text = "There are no traffic jams along the extra mile.",
                Author = "Roger Staubach",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 72,
                Text = "It is never too late to be what you might have been.",
                Author = "George Eliot",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 73,
                Text = "You become what you believe.",
                Author = "Oprah Winfrey",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 74,
                Text = "I would rather die of passion than of boredom.",
                Author = "Vincent van Gogh",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 75,
                Text = "A truly rich man is one whose children run into his arms when his hands are empty.",
                Author = "Unknown",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 76,
                Text = "It is not what you do for your children, but what you have taught them to do for themselves, that will make them successful human beings. ",
                Author = "Ann Landers",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 77,
                Text = "If you want your children to turn out well, spend twice as much time with them, and half as much money.",
                Author = "Abigail Van Buren",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 78,
                Text = "Build your own dreams, or someone else will hire you to build theirs.",
                Author = "Farrah Gray",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 79,
                Text = "The battles that count aren't the ones for gold medals. The struggles within yourself-the invisible battles inside all of us-that's where it's at.",
                Author = "Jesse Owens",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 80,
                Text = "Education costs money.  But then so does ignorance.",
                Author = "Sir Claus Moser",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 81,
                Text = "I have learned over the years that when one's mind is made up, this diminishes fear.",
                Author = "Rosa Parks",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 82,
                Text = "It does not matter how slowly you go as long as you do not stop.",
                Author = "Confucius",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 83,
                Text = "If you look at what you have in life, you'll always have more. If you look at what you don't have in life, you'll never have enough.",
                Author = "Oprah Winfrey",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 84,
                Text = "Remember that not getting what you want is sometimes a wonderful stroke of luck.",
                Author = "Dalai Lama",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 85,
                Text = "You can’t use up creativity.  The more you use, the more you have.",
                Author = "Maya Angelou",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 86,
                Text = "Dream big and dare to fail.",
                Author = "Norman Vaughan",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 87,
                Text = "Our lives begin to end the day we become silent about things that matter.",
                Author = "Martin Luther King Jr.",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 88,
                Text = "Do what you can, where you are, with what you have.",
                Author = "Teddy Roosevelt",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 89,
                Text = "If you do what you’ve always done, you’ll get what you’ve always gotten.",
                Author = "Tony Robbins",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 90,
                Text = "Dreaming, after all, is a form of planning.",
                Author = "Gloria Steinem",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 91,
                Text = "It's your place in the world; it's your life. Go on and do all you can with it, and make it the life you want to live.",
                Author = "Mae Jemison",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 92,
                Text = "You may be disappointed if you fail, but you are doomed if you don't try.",
                Author = "Beverly Sills",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 93,
                Text = "Remember no one can make you feel inferior without your consent.",
                Author = "Eleanor Roosevelt",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 94,
                Text = "Life is what we make it, always has been, always will be.",
                Author = "Grandma Moses",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 95,
                Text = "The question isn’t who is going to let me; it’s who is going to stop me.",
                Author = "Ayn Rand",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 96,
                Text = "When everything seems to be going against you, remember that the airplane takes off against the wind, not with it.",
                Author = "Henry Ford",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 97,
                Text = "It’s not the years in your life that count. It’s the life in your years.",
                Author = "Abraham Lincoln",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 98,
                Text = "Change your thoughts and you change your world.",
                Author = "Norman Vincent Peale",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 99,
                Text = "Either write something worth reading or do something worth writing.",
                Author = "Benjamin Franklin",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 100,
                Text = ". Nothing is impossible, the word itself says, “I’m possible!”",
                Author = "Audrey Hepburn",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 101,
                Text = ". The only way to do great work is to love what you do.",
                Author = "Steve Jobs",
                CreatedAt = DateTime.Today
            },
            new Quote
            {
                Id = 102,
                Text = ". If you can dream it, you can achieve it.",
                Author = "Zig Ziglar",
                CreatedAt = DateTime.Today
            }

            );
        }
    }
}
