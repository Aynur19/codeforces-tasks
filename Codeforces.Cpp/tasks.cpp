#include "tasks.h"


void task_231_A(void) {
    std::string strN;
    std::cin >> strN;

    try {
        int n = std::stoi(strN);

        if (n > 0) {
            int numberCount = 3;
            int count = 0;
            std::string strNumbers;
            std::vector<std::string> words;
            std::string delimiter = " ";
            size_t pos = 0;
            std::string strNumber;

            for (size_t i = 0; i < n; i++) {
                int confidentCount = 0;
                for (size_t j = 0; j < numberCount; j++) {
                    std::cin >> strNumber;

                    if (std::stoi(strNumber) == 1) {
                        confidentCount++;
                    }
                }

                if (confidentCount >= 2) {
                    count++;
                }
            }

            std::cout << count << std::endl;
        }
    }
    catch (std::logic_error)
    {
        return;
    }
}

void task_71_A(void)
{
    std::string strN;
    std::cin >> strN;

    try
    {
        int n = std::stoi(strN);

        if (n > 0)
        {
            std::string word;
            std::vector<std::string> words(n);

            for (size_t i = 0; i < n; i++)
            {
                std::cin >> word;
                words[i] = word;
            }

            for (size_t i = 0; i < n; i++)
            {
                size_t wordSize = words[i].size();
                if (wordSize > 10)
                {
                    std::cout << words[i][0] << wordSize - 2 << words[i][wordSize - 1] << std::endl;
                }
                else
                {
                    std::cout << words[i] << std::endl;
                }
            }
        }
    }
    catch (std::logic_error)
    {
        return;
    }
}

void task_4_A(void)
{
    std::string weightStr;
    std::cin >> weightStr;

    try
    {
        int weight = std::stoi(weightStr);

        if (weight % 2 == 0 && weight > 2)
        {
            std::cout << "YES";
        }
        else
        {
            std::cout << "NO";
        }
    }
    catch (std::invalid_argument)
    {
        std::cout << "NO";
        return;
    }
    catch (std::out_of_range)
    {
        std::cout << "NO";
        return;
    }
}