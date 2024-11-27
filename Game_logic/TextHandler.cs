using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tst_project
{
    internal class TextHandler

    {
        //Constructor
        public TextHandler()
        {
            var connection = CreateConnection();
            if (connection != null)
            {
                Console.WriteLine("Connection established successfully!");
                CreateTable(connection);
                connection.Close(); //Closes the connection after use
            }
        }

        //Create a SQLite Connection
        private SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqliteConn = new SQLiteConnection("Data Source = database.db; Version = 3; New = True; Compress = True;");

            try
            {
                sqliteConn.Open();
                Console.WriteLine("Database connection opened.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return sqliteConn;
        }

        public void CreateTable(SQLiteConnection connection)
        {
            string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS Text (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Paragraph TEXT NOT NULL
                    );";

            string insertQuery = @"
                INSERT INTO Text (Paragraph) VALUES
                    ('Technology continues to evolve rapidly, changing the way we live and interact daily. From smartphones to artificial intelligence, advancements shape modern life and challenge us to adapt continually.'),
                    ('Education is essential for individual growth and societal progress. Innovative teaching methods and accessible learning platforms are empowering people globally, paving the way for a brighter, more inclusive future.'),
                    ('Climate change is a pressing global concern. Rising temperatures, melting glaciers, and extreme weather events underscore the urgency for collective action to protect our planet and secure future generations.'),
                    ('Traveling expands horizons and fosters cultural understanding. Exploring diverse destinations allows us to appreciate history, cuisine, and traditions, enriching our lives and building bridges across nations and communities.'),
                    ('Health and wellness are vital for a balanced life. Regular exercise, a nutritious diet, and mindfulness practices can significantly improve both physical and mental well-being in the long term.'),
                    ('Music transcends boundaries, connecting people worldwide. It evokes emotions, tells stories, and brings comfort, making it an integral part of cultures and personal experiences throughout human history.'),
                    ('Effective communication is a cornerstone of success. Whether in personal relationships or professional settings, clear and empathetic dialogue fosters understanding, builds trust, and resolves conflicts constructively.'),
                    ('Reading is a gateway to knowledge and imagination. Books allow us to explore new worlds, learn valuable lessons, and develop critical thinking skills, all while enjoying an immersive experience.'),
                    ('Sustainable living is gaining momentum globally. Simple practices like reducing waste, conserving energy, and supporting eco-friendly initiatives contribute to environmental preservation and help combat the effects of climate change.'),
                    ('Digital transformation revolutionizes industries, streamlining processes and enhancing efficiency. Businesses adopting innovative technologies gain competitive advantages, while consumers benefit from improved services and personalized experiences.'),
                    ('Volunteerism fosters community spirit and mutual support. Giving time and effort to assist others creates positive impacts, strengthens social ties, and promotes empathy within and beyond local neighborhoods.'),
                    ('Creativity drives innovation and problem-solving. Encouraging creative thinking in education, workplaces, and everyday life enables individuals and organizations to tackle challenges with fresh perspectives and effective solutions.'),
                    ('Language connects people and preserves cultures. Learning new languages bridges gaps, fosters global understanding, and offers insights into diverse ways of thinking and perceiving the world.'),
                    ('Entrepreneurship fuels economic growth and innovation. Bold ideas, determination, and resilience transform businesses into impactful ventures, creating opportunities and inspiring future generations to pursue their passions.'),
                    ('Mental health awareness is crucial in today's fast-paced world. Recognizing the importance of emotional well-being ensures individuals can access support and resources for a healthier, more balanced life.'),
                    ('Art is a powerful medium for expression. From paintings to sculptures, creative works communicate complex emotions and ideas, reflecting societies and inspiring viewers across generations.'),
                    ('History teaches valuable lessons about resilience and progress. Understanding past events allows societies to make informed decisions, avoid repeating mistakes, and appreciate the context shaping current realities.'),
                    ('Technological advancements redefine transportation. Electric vehicles, high-speed trains, and autonomous systems promise greener, faster, and more efficient ways to travel while reducing environmental impacts.'),
                    ('Sports unite communities and inspire teamwork. Participating in or watching games fosters a sense of belonging, encourages healthy competition, and highlights the importance of perseverance and collaboration.'),
                    ('Nature offers solace and inspiration. Spending time outdoors, surrounded by greenery, reduces stress and fosters mindfulness, connecting us to the Earth's inherent beauty and tranquility.'),
                    ('The power of storytelling is timeless. Whether through books, films, or oral traditions, stories captivate audiences, preserve heritage, and convey universal truths about human experiences and emotions.'),
                    ('Cities are hubs of opportunity and innovation. Urban areas drive economic growth, foster cultural exchange, and offer vibrant lifestyles, though they must address challenges like congestion and sustainability.'),
                    ('Education empowers individuals to reach their potential. Quality learning experiences instill confidence, enhance skills, and open doors to better opportunities, creating ripple effects across societies.'),
                    ('Social media reshapes how we connect. Platforms enable instant communication and global networking, but users must navigate challenges like misinformation, privacy concerns, and screen time moderation.'),
                    ('Wildlife conservation safeguards biodiversity. Protecting ecosystems ensures balance in nature, supporting species and mitigating the risks of habitat destruction and climate-related threats.'),
                    ('Innovation thrives in collaboration. When diverse perspectives come together, they foster groundbreaking ideas and solutions, driving progress in fields ranging from medicine to technology and beyond.'),
                    ('Personal growth requires introspection and action. Setting goals, embracing change, and learning from failures pave the way for self-improvement and fulfillment in life’s journey.'),
                    ('Resilience enables individuals to overcome adversity. Strength of character and adaptability are essential for navigating life's challenges and emerging stronger from difficult experiences.'),
                    ('Renewable energy offers sustainable solutions. Solar, wind, and hydropower reduce reliance on fossil fuels, helping combat climate change and ensuring a cleaner, greener future.'),
                    ('Friendship enriches life with support and joy. Building meaningful connections with others enhances our experiences, fosters empathy, and creates lasting memories filled with laughter and companionship.');";


            try
            {
                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Table 'Text' created successfully.");
                }

                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Multiple rows inserted succesfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating table or inserting data: {ex.Message}");
            }

        }

    }

}


