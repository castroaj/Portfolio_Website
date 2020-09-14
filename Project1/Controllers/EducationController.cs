using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Models;

namespace Web.Controllers {

    public class EducationController : Controller {

        private readonly ILogger<HomeController> _logger;
        private EducationModel educationModel; 

        public EducationController(ILogger<HomeController> logger)
        {
            _logger = logger;

            educationModel = new EducationModel(){
            csCourses = EducationController.getComputerScienceCourses(),
            cisCourses = EducationController.getCISCourses(),
            genEdCourses = EducationController.getGeneralEducationCourses()
            };
        } 

        public IActionResult Index()
        {
            return View(educationModel);
        }

        public static List<Course> getCISCourses()
        {
            return new List<Course>() {
                new Course() {
                    CourseNum = "204", CourseTitle = "Computer Information Systems", LetterGrade = "B+", Credits = "3", Description = "An introduction to computer-based information systems. Emphasis is placed on the role of computers in organizations and society, computer hardware and software, uses of information systems, computer ethics, and collaboration using computers. Students will use typical business applications. This course is designed to fulfill requirements for the General Business minor. Not open to business majors."
                },
                new Course() {
                    CourseNum = "304", CourseTitle = "Enterprise Architechture and Cloud Computing", LetterGrade = "IN PROGRESS", Credits = "3", Description = "This course explores the analysis, design, implementation, evaluation and management of enterprise IT solutions. Emphasis will be placed on planning and modeling the enterprise. Topics include functional modeling, physical architecture design, security planning and recovery issues, project management, emerging technologies, and ethical, financial and global considerations"
                }
            };
        }

        public static List<Course> getGeneralEducationCourses()
        {
            return new List<Course>() {
                new Course {
                    CourseNum = "KIN 100", CourseTitle = "Lifetime Fitness and Wellness (Cardio / Strength)", LetterGrade = "B", Credits = "3", Description = "This course is designed to help students adopt and maintain the behaviors associated with an active and healthy lifestyle. Students will learn the facts about fitness, wellness, and physical activity, become an informed fitness, wellness, and exercise consumer, and plan their own personal lifetime fitness and wellness program. Through this course, students will learn the importance of maintaining fitness and wellness through a physically active lifestyle. Through lectures and physical activity labs, students will study and develop the behavioral patterns consistent with the current knowledge base in fitness and wellness."
                }, 
                new Course {
                    CourseNum = "MATH 231-232", CourseTitle = "Calculus With Functions I & II", LetterGrade = "C", Credits = "6", Description = "Math 231-232 is a two-semester calculus sequence that covers first-semester calculus along with precalculus and algebra material"
                },
                new Course {
                    CourseNum = "THEA 210", CourseTitle = "Introduction To Theatre", LetterGrade = "C+", Credits = "3", Description = "Study of the theatre as an art form. Emphasis on introducing students to a broad spectrum of theatrical activity and opinion. Consideration of the components that comprise a theatre event including acting, directing, design, costuming, lighting and playwriting."
                },
                new Course {
                    CourseNum = "POSC 225", CourseTitle = "U.S. Government", LetterGrade = "CREDIT", Credits = "4", Description = "An examination of institutions, processes and intellectual concepts which structure American political activity. The interaction of the political system with the changing American society and America's changing role in world affairs are also treated. The course provides an introduction to quantitative methodology."
                },
                new Course {
                    CourseNum = "ISAT 160", CourseTitle = "Problem Solving Application in Science And Technology", LetterGrade = "A-", Credits = "3", Description = "This course examines issues in modern science and technology as a means to introduce, develop and enhance critical thinking and problem solving skills. Current scientific and technological research and applications will be introduced to reinforce problem solving, instruction in systems thinking and critical inquiry. The course provides opportunities for using both oral and written communication in a variety of learning activities."
                },
                new Course {
                    CourseNum = "SCOM 122", CourseTitle = "Fundemental Human Communication: Individual Presentation", LetterGrade = "B-", Credits = "3", Description = "Study of human communication as a process. Overview of the principles and practices of interpersonal, small group and public communication. Emphasis on examining the role of self-concept, perception, culture, verbal and nonverbal dimensions in the communication process, using power and managing conflict, applying critical listening, practicing audience analysis within informative speech making. Public speaking required."
                },
                new Course {
                    CourseNum = "WRTC 103", CourseTitle = "Critical Reading and Writing", LetterGrade = "A-", Credits = "3", Description = "Fosters reflective, critical reading, writing, and research in public discourse, culture, humanities, technology, and science. Challenges students to consider cross disciplinary modes of inquiry through multiple genres with an attention to enlightened, global citizenship. Emphasizes revising for rhetorical effectiveness. "
                },
                new Course {
                    CourseNum = "ECON 200", CourseTitle = "Intro to Macroeconomics", LetterGrade = "B", Credits = "3", Description = "Behavior of systems at the national and international levels. Topics include the methodology of economics as a social science, supply and demand, definition and measurement of important macroeconomic variables, and theoretical models of growth, inflation, interest rates, unemployment, business cycles, stabilization policy, exchange rates and the balance of payments. "
                },
                new Course {
                    CourseNum = "PSYC 101", CourseTitle = "General Psychology", LetterGrade = "A", Credits = "3", Description = "A study of the nervous system, sensation, perception, consciousness, learning, memory, language, intelligence, motivation, emotion, life span development, personality, psychopathology, psychotherapy, social psychology and the scientific method."
                },
                new Course {
                    CourseNum = "MATH 220", CourseTitle = "Elementary Statistics", LetterGrade = "B", Credits = "3", Description = "Descriptive statistics, frequency distributions, sampling, estimation and testing of hypotheses, regression, correlation and an introduction to statistical analysis using computers."
                },
                new Course {
                    CourseNum = "GEO 102", CourseTitle = "Enviornment: Earth studies", LetterGrade = "B+", Credits = "3", Description = "A study of geological processes causing global change and their impact on human thought. The relationship between some geological processes and life on the Earth is also considered."
                },
                new Course {
                    CourseNum = "PHYS 121", CourseTitle = "Physical nature of Light and Sound", LetterGrade = "A", Credits = "4", Description = "A study of the physical properties of light and sound waves. Topics include production, propagation and spectral analysis of waves. Applications to be covered include musical instruments, sound reproduction, room acoustics, optical instruments (cameras, projectors, lasers), and color in art and nature."
                },
                new Course {
                    CourseNum = "HUM 200", CourseTitle = "Great Works: American Century", LetterGrade = "IN PROGRESS", Credits = "3", Description = "An intensive examination of great literary works that focus on key issues of knowledge and reality, meaning and purpose, ethics, and aesthetics."
                }
            };
        }


        public static List<Course> getComputerScienceCourses()
        {
            return new List<Course>() 
            {
                new Course() {
                    CourseNum = "101", CourseTitle = "Introduction to Computer Science", LetterGrade = "B+", Credits = "3", Description = "How to think like a computer scientist. Topics include an overview of the context of computing, computational operations, computational devices, algorithms and data structures, the storage and transmission of data, the presentation of information, and the limits of computing. Students learn about the design and implementation of computational systems, the value of abstraction, problem solving and the ways in which computation impacts society."
                },
                new Course() {
                    CourseNum = "149", CourseTitle = "Programming Fundamentals", LetterGrade = "A-", Credits = "3", Description = "Students learn fundamental problem-solving techniques using a modern programming language. This course covers same material as CS 139, but at an accelerated pace for students with programming experience."
                },
                new Course() {
                    CourseNum = "159", CourseTitle = "Advanced Programming", LetterGrade = "B-", Credits = "3", Description = "Students use advanced problem-solving strategies to develop algorithms using classes and objects and techniques such as recursion, exceptions and file I/O. This course also focuses on designing small applications and effective testing strategies."
                },
                new Course() {
                    CourseNum = "227", CourseTitle = "Discrete Structures I", LetterGrade = "A", Credits = "3", Description = "An introduction to discrete mathematical structures including functions, relations, sets, logic, matrices, elementary number theory, proof techniques, basics of counting, graphic theory, discrete probability, digital logic, finite state machines, integer and floating point representations."
                },
                new Course() {
                    CourseNum = "240", CourseTitle = "Data Structures and Algorithms", LetterGrade = "B", Credits = "3", Description = "Students learn to implement and analyze elementary data structures and the basic complexity classes of algorithms that use strategies such as greedy algorithms, divide-and-conquer algorithms and backtracking algorithms. This analysis is especially applied to problems in searching, sorting and parsing."
                },
                new Course() {
                    CourseNum = "260", CourseTitle = "Technical Communication for Computer Science", LetterGrade = "A", Credits = "3", Description = "An introduction to the process of planning, researching, producing, and revising technical documents attuned to specific audiences in the computing industry. Document forms studied include definitions, correspondence, descriptions, specifications, instructions, proposals, reports, resumes and plans."
                },
                new Course() {
                    CourseNum = "261", CourseTitle = "Computer Systems I", LetterGrade = "A-", Credits = "3", Description = "Introduction to the operation of modern interrupt-driven computer systems. Explores the representation of software and information in binary memory, the primary components of a CPU, multithreaded programming and basic interactions with an Operating System."
                },
                new Course() {
                    CourseNum = "327", CourseTitle = "Discrete Structures II", LetterGrade = "A-", Credits = "3", Description = "This course builds on the theoretical foundation developed in Discrete Structures I. Students study a range of topics from discrete mathematics and theoretical computer science including elementary number theory, matrices, graph theory, automata, computability and complexity theory."
                },
                new Course() {
                    CourseNum = "345", CourseTitle = "Software Engineering", LetterGrade = "B", Credits = "3", Description = "Study of modern methods and tools for the development of software products. Topics include software development process models, software development tools, design and construction principles and practice, software quality assurance and program management."
                },
                new Course() {
                    CourseNum = "361", CourseTitle = "Computer Systems II", LetterGrade = "A-", Credits = "3", Description = "Intermediate exploration of modern interrupt-driven computer systems. Explores models of computation and complex systems, techniques for communication and synchronization of parallel and concurrent software, and the protocols that make up the Internet."
                },
                new Course() {
                    CourseNum = "374", CourseTitle = "Database Systems", LetterGrade = "IN PROGRESS", Credits = "3", Description = "Students study database design and management with emphasis placed on data definition languages, data manipulation languages, query languages and management of the database environment."
                },
                new Course() {
                    CourseNum = "430", CourseTitle = "Programming Languages", LetterGrade = "A", Credits = "3", Description = "Several actual programming languages are studied in terms of the fundamental principles of computer programming language design, including object-oriented programming, functional programming, concurrent programming and logic programming."
                },
                new Course() {
                    CourseNum = "457", CourseTitle = "Information Security", LetterGrade = "A", Credits = "3", Description = "This course covers the basic issues of information system security. The roles of planning, management, policies, procedures and personnel in protecting the confidentiality, integrity and availability of information are described. Specific threats (malicious code, network attacks and hostile content) and widely used countermeasures (access control, mechanisms, firewalls and intrusion detection systems) are also discussed."
                },
                new Course() {
                    CourseNum = "458", CourseTitle = "Cyber Defense", LetterGrade = "IN PROGRESS", Credits = "3", Description = "A hands-on, lab-based learning experience in which the students engage in a series of mini projects to perform security assessment, penetration testing and hardening of networked systems. Students also participate in a cyber defense exercise."
                },
                new Course() {
                    CourseNum = "482", CourseTitle = "Cryptography", LetterGrade = "IN PROGRESS", Credits = "3", Description = "Selected Topics in information security. Explores different cryptographic schemes and algorithms. Topics include symmetric encryption, public-key cryptography, hash functions, and block chain."
                },
            };
        }

    }
}